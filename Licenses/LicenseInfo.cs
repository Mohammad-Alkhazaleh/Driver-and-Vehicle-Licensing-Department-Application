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
    public partial class LicenseInfo : Form
    {
        private int _LDLAppID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsLicenses _License;
        private clsApplications _Application;
        private clsPerson _Person;
        public LicenseInfo(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private string GetGender(int Gender)
        //{
        //    return (Gender == 0 ? "Male" : "Female");
        //}
        //private string GetIssueReason(int IssueReason)
        //{
        //    return ((IssueReason == 1 ? "First Time" : (IssueReason == 2 ? "Renew" : (IssueReason == 3 ? "Replacement for Damaged" : "Replacement for Lost"))));
        //}
        //private string _GetIsActive(bool isActive)
        //{
        //    return (isActive ? "Yes" : "No");
        //}
        //private string _GetIsDetaind(bool IsDetaind)
        //{
        //    return (IsDetaind ? "Yes" : "No");
        //}
        //private void _FillData()
        //{
           
        //    _Person = clsPerson.Find(_Application.ApplicantPersonID);
        //    lblClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLApp.LicenseClassID);
        //    lblFullName.Text = _Person.FullName;
        //    lblLicenseID.Text = _License.LicenseID.ToString();
        //    lblNationalNo.Text = _Person.NationalNo;
        //    lblGender.Text = GetGender(_Person.Gender);
        //    lblIssueDate.Text = _License.IssueDate.ToString("d");
        //    lblIssueReason.Text = GetIssueReason(_License.IssueReason);
        //    lblNotes.Text = _License.Notes;
        //    lblIsActive.Text = _GetIsActive(_License.IsActive);
        //    lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
        //    lblDriverID.Text = _License.DriverID.ToString();
        //    lblExpirationDate.Text = _License.ExpirationDate.ToString("d");
        //    lblIsDetained.Text = _GetIsDetaind(clsDetainedLicense.IsLicenseDetained(_License.LicenseID));
        //    pbImage.ImageLocation = _Person.ImagePath;
        //}
        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            if (_LDLAppID <0)
            {
                MessageBox.Show("Invalid local driving license application !");
                this.Close();
                return;
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            if(_LDLApp == null)
            {
                MessageBox.Show("There is no local driving license application with this ID !");
                this.Close();
                return;
            }
            ucDriverLicenseInfo1.FillData(ref _LDLApp);
          
            
        }
    }
}
