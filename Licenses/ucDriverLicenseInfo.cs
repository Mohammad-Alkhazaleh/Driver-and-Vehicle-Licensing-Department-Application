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
    public partial class ucDriverLicenseInfo : UserControl
    {
        private clsPerson _Person;
        private clsApplications _Application;
        private clsLicenses _License;
        private clsLocalDrivingLicenseApplication _LDLApp;
        public ucDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private string GetGender(int Gender)
        {
            return (Gender == 0 ? "Male" : "Female");
        }
        private string GetIssueReason(int IssueReason)
        {
            return ((IssueReason == 1 ? "First Time" : (IssueReason == 2 ? "Renew" : (IssueReason == 3 ? "Replacement for Damaged" : "Replacement for Lost"))));
        }
        private string _GetIsActive(bool isActive)
        {
            return (isActive ? "Yes" : "No");
        }
        private string _GetIsDetaind(bool IsDetaind)
        {
            return (IsDetaind ? "Yes" : "No");
        }
        public void FillData(int LicenseID)
        {
            _License = clsLicenses.Find(LicenseID);
            _Application = clsApplications.Find(_License.ApplicationID);
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            lblClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_License.LicenseClassID);
            lblFullName.Text = _Person.FullName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = GetGender(_Person.Gender);
            lblIssueDate.Text = _License.IssueDate.ToString("d");
            lblIssueReason.Text = GetIssueReason(_License.IssueReason);
            lblNotes.Text = _License.Notes;
            lblIsActive.Text = _GetIsActive(_License.IsActive);
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToString("d");
            lblIsDetained.Text = _GetIsDetaind(clsDetainedLicense.IsLicenseDetained(_License.LicenseID));
            pbImage.ImageLocation = _Person.ImagePath;
        }
         
        public void FillData(ref clsLocalDrivingLicenseApplication LDLApp)
        {
            
            _LDLApp = LDLApp;
            _Application = clsApplications.Find(_LDLApp.ApplicationID);
           
            _License = clsLicenses.FindByApplicationID(_LDLApp.ApplicationID);
            if (_License == null)
            {
                MessageBox.Show("There is no license with this ID !");
                return;
            }
            
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            lblClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLApp.LicenseClassID);
            lblFullName.Text = _Person.FullName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = GetGender(_Person.Gender);
            lblIssueDate.Text = _License.IssueDate.ToString("d");
            lblIssueReason.Text = GetIssueReason(_License.IssueReason);
            lblNotes.Text = _License.Notes;
            lblIsActive.Text = _GetIsActive(_License.IsActive);
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToString("d");
            lblIsDetained.Text = _GetIsDetaind(clsDetainedLicense.IsLicenseDetained(_License.LicenseID));
            pbImage.ImageLocation = _Person.ImagePath;
        }

        private void ucDriverLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
