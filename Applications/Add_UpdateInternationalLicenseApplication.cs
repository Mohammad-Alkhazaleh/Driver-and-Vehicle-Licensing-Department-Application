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
using static System.Net.Mime.MediaTypeNames;

namespace NewDVLD_Project.Applications
{
    public partial class Add_UpdateInternationalLicenseApplication : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsLicenses _LocalLicense;
        private enum enMode { AddNew , Update}
        private enMode _Mode;
        private clsApplications _Application;
        private clsInternationalLicenses _InternationLicense;
        public Add_UpdateInternationalLicenseApplication()
        {
            InitializeComponent();
            ucInternationalLicenseFilter1.OnLicenseFound += _GetLicense;
            _Mode = enMode.AddNew;
        }

        private void _GetLicense(int LicenseID)
        {
            ucDriverLicenseInfo1.FillData(LicenseID);
            _LocalLicense = clsLicenses.Find(LicenseID);
            lblLocalLicenseID.Text = _LocalLicense.LicenseID.ToString();
            lblFees.Text = (clsApplicationTypes.GetApplicationFeesByAppTitle("New International License") + clsLicenseClass.GetLicenseClassFeesByName(clsLicenseClass.GetLicenseClassNameByID(_LocalLicense.LicenseClassID))).ToString();
        }
        private void Add_UpdateInternationalLicenseApplication_Load(object sender, EventArgs e)
        { 
            lblFees.Text = (clsApplicationTypes.GetApplicationFeesByAppTitle("New International License")).ToString();
            lbl_I_CreatedBy.Text =clsUser.CurrentUserInfo.UserID.ToString();
        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_LocalLicense.LicenseID));
            frm.ShowDialog();
        }

        private void llShowLicesnesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            LicenseHistory frm = new LicenseHistory(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_LocalLicense.LicenseID));
            frm.ShowDialog();
        }

        private void ucInternationalLicenseFilter1_Load(object sender, EventArgs e)
        {
            if (_Mode==enMode.AddNew)
            {
                _Application = new clsApplications();
                _InternationLicense = new clsInternationalLicenses();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_LocalLicense ==null)
            {
                MessageBox.Show("Please , choose a local lisense before issue !");
                return;
            }
            if (clsLicenses.IsLicenseHasInternationalLicense(_LocalLicense.LicenseID))
            {
                MessageBox.Show($"There is an international license for this LocalLicenseID {_LocalLicense.LicenseID}!");
                return;
            }
            _Application.ApplicationStatus =3;
            _Application.PaidFees = (clsApplicationTypes.GetApplicationFeesByAppTitle("New International License") + clsLicenseClass.GetLicenseClassFeesByName(clsLicenseClass.GetLicenseClassNameByID(_LocalLicense.LicenseClassID)));
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            _Application.ApplicationTypeID = clsApplicationTypes.GetApplicationTypeIDByAppTitle("New International License");
            _Application.ApplicationDate =DateTime.Now;
            _Application.ApplicantPersonID =clsApplications.Find(_LocalLicense.ApplicationID).ApplicantPersonID;
            if (_Application.Save())
            {
                lbl_I_L_ApplicationID.Text=_Application.ApplicationID.ToString();
                lblApplicationDate.Text =_Application.ApplicationDate.ToString("d");
                _InternationLicense.ApplicationID = _Application.ApplicationID;
                _InternationLicense.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
                _InternationLicense.DriverID = clsDriver.GetDriverIDByPersonID(_Application.ApplicantPersonID);
                _InternationLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(_LocalLicense.LicenseClassID).DefaultValidityLength);
                _InternationLicense.IsActive = true;
                _InternationLicense.IssuedUsingLocalLicenseID = _LocalLicense.LicenseID;
                _InternationLicense.IssueDate = DateTime.Now;

                if (_InternationLicense.Save())
                {
                    lbl_I_L_LicesneID.Text = _InternationLicense.InternationLicenseID.ToString();
                    lbl_I_IssueDate.Text = _InternationLicense.IssueDate.ToString("d");
                    lbl_I_ExpirationDate.Text = _InternationLicense.ExpirationDate.ToString("d");
                    MessageBox.Show("Internationl license saved successfully...","Success");
                }
                else
                {
                    MessageBox.Show("Internationl license failed to save successfully...","Fail");
                }
            }
            else
            {
                MessageBox.Show("Application failed to save successfully !");
            }
            

        }
    }
}
