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

namespace NewDVLD_Project.Applications
{
    public partial class RenewDrivingApplication : Form
    {
        private clsLicenses _License;
        private clsApplications OldApp;
        private clsLicenses NewLicense;
        private clsApplications NewApp;
        public RenewDrivingApplication()
        {
            InitializeComponent();
            ucInternationalLicenseFilter1.OnLicenseFound += GetLicenseID;
            llShowLicesnesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
        }
        private void GetLicenseID(int LicenseID)
        {
            _License = clsLicenses.Find(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("No License with this ID!");
                llShowLicesnesHistory.Enabled = false;
                llShowNewLicensesInfo.Enabled = false;
                return;
            }
            if (_License.IsActive)
            {
                MessageBox.Show("This license is active  ,you can not renew a license!");
                return;
            }
           
            ucDriverLicenseInfo1.FillData(LicenseID);
           
                llShowLicesnesHistory.Enabled = true;
                llShowNewLicensesInfo.Enabled = true;
            OldApp  = clsApplications.Find(_License.ApplicationID);

            lblOldLicenseID.Text = LicenseID.ToString();
            lbl_R_CreatedBy.Text = clsUser.CurrentUserInfo.UserName;
            lblApplicationDate.Text = DateTime.Now.ToString("d");
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle("Renew Driving License Service").ToString();
            lblLicenseFees.Text = clsLicenseClass.GetLicenseClassFeesByName(clsLicenseClass.GetLicenseClassNameByID(_License.LicenseClassID)).ToString();
            lblTotalFees.Text = (Convert.ToInt32(lblApplicationFees.Text) + Convert.ToInt32(lblLicenseFees.Text)).ToString();
            lbl_R_IssueDate.Text = DateTime.Now.ToString("d") ;
            lbl_R_ExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClass.Find(_License.LicenseClassID).DefaultValidityLength).ToString("d");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewDrivingApplication_Load(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            
            if (_License ==null)
            {
                MessageBox.Show("please choose a license !");
                return;
            }
            NewApp = new clsApplications();
            NewApp.ApplicantPersonID = OldApp.ApplicantPersonID;
            NewApp.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
            NewApp.ApplicationStatus = 3;
            NewApp.ApplicationTypeID = clsApplicationTypes.GetApplicationTypeIDByAppTitle("Renew Driving License Service");
            NewApp.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            NewApp.LastStatusDate = DateTime.Now;
            NewApp.PaidFees = Convert.ToInt32(lblApplicationFees.Text);
            if (!NewApp.Save())
            {
                MessageBox.Show("Application failed to save successfully !", "Fail");
                return;
            }
            lbl_R_L_ApplicationID.Text = NewApp.ApplicationID.ToString();
            NewLicense = new clsLicenses();
            NewLicense.ApplicationID = NewApp.ApplicationID;
            NewLicense.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            NewLicense.PaidFees = Convert.ToInt32(lblTotalFees.Text);
            NewLicense.IssueDate = Convert.ToDateTime(lbl_R_IssueDate.Text);
            NewLicense.ExpirationDate = Convert.ToDateTime(lbl_R_ExpirationDate.Text);
            NewLicense.IsActive = true;
            NewLicense.IssueReason = 2;
            NewLicense.Notes = txtbNotes.Text;
            NewLicense.DriverID = _License.DriverID;
            NewLicense.LicenseClassID = _License.LicenseClassID;
            if (NewLicense.Save())
            {
                lbl_Renewed_LicesneID.Text = NewLicense.LicenseID.ToString();
                MessageBox.Show("License renewed successfully !", "Success");
                btnRenew.Enabled = false;
            }
            else
            {
                MessageBox.Show("License failed to renew successfully !", "Fail");
            }


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
    }
}
