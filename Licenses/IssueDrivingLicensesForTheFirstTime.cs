using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project.Licenses
{
    public partial class IssueDrivingLicensesForTheFirstTime : Form
    {
        private clsApplications _Application;
        private int _LDLAppID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsLicenses _License = new clsLicenses();//خطأ وضعه هنا
        private clsDriver _Driver =new clsDriver();//خطأ وضعه هنا
        public IssueDrivingLicensesForTheFirstTime(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueDrivingLicensesForTheFirstTime_Load(object sender, EventArgs e)
        {
            if (_LDLAppID <0)
            {
                MessageBox.Show("Invalid Local driving license application ID !");
                this.Close();
                return;
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            if (_LDLApp ==null)
            {
                MessageBox.Show("No Local driving license application with this ID!");
                this.Close();
                return;
            }
            _Application = clsApplications.Find(_LDLApp.ApplicationID);
            ucDrivingLicenseApplicationInfo1.FillDivingLicenseAppInfo(_LDLAppID);
            ucApplicationInfo1.FillApplicationInfo(_LDLApp.ApplicationID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int DriverID = 0;
            if ((DriverID =clsDriver.IsPersonHasDriver(_Application.ApplicantPersonID) )==-1)
            {
                _Driver.PersonID = _Application.ApplicantPersonID;
                _Driver.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
                _Driver.CreatedDate = DateTime.Now;
                if (!_Driver.Save())
                {
                    MessageBox.Show("Driver failed to save", "Fail");
                    return;
                }
            }

            _Driver = clsDriver.Find(DriverID);
            _License.ApplicationID = _LDLApp.ApplicationID;
            _License.DriverID = _Driver.DriverID;
            _License.LicenseClassID = _LDLApp.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = (DateTime.Now.AddYears(clsLicenseClass.Find(_LDLApp.LicenseClassID).DefaultValidityLength));
            _License.Notes = txtbNotes.Text;
            _License.PaidFees = _Application.PaidFees;
            _License.IsActive = true;
            _License.IssueReason = _Application.ApplicationTypeID;
            _License.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            if (_License.Save())
            {
                MessageBox.Show("License saved successfully...","Success");
            }
            else
            {
                MessageBox.Show("License failed to save successfully...", "Fail");
            }
          

        }
    }
}
