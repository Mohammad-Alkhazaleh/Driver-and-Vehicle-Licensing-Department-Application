using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project.Applications
{
    public partial class ReplacmentForLostOrDamaged : Form
    {
        private clsLicenses _License;
        private clsApplications NewApplication;
        private clsLicenses NewLicense;
        public ReplacmentForLostOrDamaged()
        {
            InitializeComponent();
            ucInternationalLicenseFilter1.OnLicenseFound += GetLicenseID;
            llShowLicesnesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
            rbDamagedLicense.Checked = true;
        }
        private string _GetApplicationTypeTitle()
        {
            return (rbDamagedLicense.Checked? "Replacement for a Damaged Driving License" : "Replacement for a Lost Driving License");
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
            if (!_License.IsActive)
            {
                MessageBox.Show("This license is not active  ,you should renew one!");
                return;
            }
            if (clsDetainedLicense.IsLicenseDetained(_License.LicenseID))
            {
                MessageBox.Show("This license is detained  ,you should release it!");
                return;
            }

            ucDriverLicenseInfo1.FillData(LicenseID);

            llShowLicesnesHistory.Enabled = true;
            llShowNewLicensesInfo.Enabled = true;
            
            lblOldLicenseID.Text = LicenseID.ToString();
            lbl_R_CreatedBy.Text = clsUser.CurrentUserInfo.UserName;
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle(_GetApplicationTypeTitle()).ToString();
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReplacmentForLostOrDamaged_Load(object sender, EventArgs e)
        {

        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle(_GetApplicationTypeTitle()).ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle(_GetApplicationTypeTitle()).ToString();
        }
        private int _IssueReason()
        {
            return (rbDamagedLicense.Checked?3:4);
        }
        private void btnReplacment_Click(object sender, EventArgs e)
        {
            if (_License ==null)
            {
                MessageBox.Show("No License with this ID!");
                return;
            }
            NewApplication = new clsApplications();
            NewApplication.ApplicationTypeID = clsApplicationTypes.GetApplicationTypeIDByAppTitle(_GetApplicationTypeTitle());
            NewApplication.ApplicationStatus = 3;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.LastStatusDate= DateTime.Now;
            NewApplication.PaidFees = Convert.ToInt32(lblApplicationFees.Text);
            NewApplication.ApplicantPersonID = clsApplications.Find(_License.ApplicationID).ApplicantPersonID;
            NewApplication.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            if (!NewApplication.Save())
            {
                MessageBox.Show("Application failed to save successfully!");
                return;
            }
            lblApplicationDate.Text = NewApplication.ApplicationDate.ToString("d");
            lbl_L_R_ApplicationID.Text = NewApplication.ApplicationID.ToString();
            NewLicense = new clsLicenses();
            NewLicense.PaidFees = Convert.ToInt32(lblApplicationFees.Text);
            NewLicense.ApplicationID = NewApplication.ApplicationID;
            NewLicense.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            NewLicense.DriverID = _License.DriverID;
            NewLicense.Notes = _License.Notes;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = _IssueReason();
            NewLicense.LicenseClassID = _License.LicenseClassID;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(_License.LicenseClassID).DefaultValidityLength);
            //disactive the old license;
            _License.IsActive = false;
            if (!_License.Save())
            {
                NewApplication.DeleteApplication();
                MessageBox.Show("Old license failed to disactive successfully!");
                return;
            }
            if (NewLicense.Save())
            {
                lbl_Replaced_LicesneID.Text = NewLicense.LicenseID.ToString();
                MessageBox.Show("License replaced successfully!");
            }
            else
            {
                NewApplication.DeleteApplication();
                MessageBox.Show("License failed to replace successfully!");
            }
        }
    }
}
