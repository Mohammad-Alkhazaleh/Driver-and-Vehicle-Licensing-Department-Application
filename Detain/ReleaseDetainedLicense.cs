using DVLD_Buisness;
using NewDVLD_Project.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_Buisness.clsPerson;

namespace NewDVLD_Project.Detain
{
    public partial class ReleaseDetainedLicense : Form
    {
        private clsLicenses _License;
        private clsDetainedLicense _DetainedLicense;
        private clsApplications _NewApplication ,_Application;
        public ReleaseDetainedLicense()
        {
            InitializeComponent();
            ucLicenseFilter1.OnLicenseFound += GetLicenseID;
            llShowLicesnesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
            
        }
        public ReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            ucLicenseFilter1.OnLicenseFound += GetLicenseID;
            llShowLicesnesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle("Release Detained Driving Licsense").ToString();
            GetLicenseID(LicenseID);
        }
        private void GetLicenseID(int LicenseID)
        {
            _License = clsLicenses.Find(LicenseID);

            if ((_DetainedLicense = clsDetainedLicense.Find(_License.LicenseID))==null )
            {
                MessageBox.Show("This license is not detained !");
                return;
            }
            if (!_License.IsActive)
            {
                MessageBox.Show("The license is not active !");
                return;
            }
            if (_DetainedLicense.IsReleased)
            {
                MessageBox.Show("This license is released !");
                return;
            }         
            ucDriverLicenseInfo1.FillData(LicenseID);
            if (_License == null)
            {
                llShowLicesnesHistory.Enabled = false;
                llShowNewLicensesInfo.Enabled = false;
            }
            else
            {
                llShowLicesnesHistory.Enabled = true;
                llShowNewLicensesInfo.Enabled = true;
            }
            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lbl_D_LicenseID.Text = _License.LicenseID.ToString();
            lbl_R_CreatedBy.Text = clsUser.Find(_DetainedLicense.CreatedByUserID).UserName;
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            int.TryParse(lblApplicationFees.Text , out int Applicationfees);
            lblTotalFees.Text = (Applicationfees + _DetainedLicense.FineFees).ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToString("d");
            
        }
        private void FillDetainInfo()
        {
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle("Release Detained Driving Licsense").ToString();

        }
        private void llShowLicesnesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_License.LicenseID));
            frm.ShowDialog();
        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_License.LicenseID));
            frm.ShowDialog();
        }

        private void ReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            FillDetainInfo();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_License ==null)
            {
                MessageBox.Show("Please choose a license");
                return;
            }
            _NewApplication = new clsApplications();
            _NewApplication.ApplicantPersonID =(_Application =  clsApplications.Find(_License.ApplicationID)).ApplicantPersonID;
            _NewApplication.ApplicationDate = DateTime.Now;
            _NewApplication.ApplicationStatus = 3;
            _NewApplication.ApplicationTypeID = _Application.ApplicationTypeID;
            _NewApplication.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            _NewApplication.LastStatusDate = DateTime.Now;
            _NewApplication.PaidFees = Convert.ToInt32(lblTotalFees.Text);
            if (!_NewApplication.Save())
            {
                MessageBox.Show("Application failed to save successfully...","Fail");
                return;
            }
            lbl_D_ApplicationID.Text = _NewApplication.ApplicationID.ToString();
            _DetainedLicense.ReleaseApplicationID = _NewApplication.ApplicationID;
            _DetainedLicense.ReleaseDate = _NewApplication.ApplicationDate;
            _DetainedLicense.ReleasedByUserID = _NewApplication.CreatedByUserID;
            _DetainedLicense.IsReleased = true;
            if (_DetainedLicense.Save())
            {
                MessageBox.Show("License released successfully...", "Success");
            }
            else
            {
                MessageBox.Show("License failed to release successfully...", "Fail");
            }

        }
    }
}
