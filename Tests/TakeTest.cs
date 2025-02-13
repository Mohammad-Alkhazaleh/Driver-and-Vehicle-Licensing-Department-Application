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

namespace NewDVLD_Project.Tests
{
    public partial class TakeTest : Form
    {
        private int _TestTypeID;
        private int _TestAppointmentID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsTestAppointments _TestAppointment;
        private enum enMode { AddNew ,Update}
        private enMode _Mode;
        private clsApplications _Application;
        private clsTests _Test;
        private bool _IsStreetTest =false;
        public TakeTest(int TestAppintmentID,int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
            _TestAppointmentID = TestAppintmentID;
            _Mode = enMode.Update;
        }
        private void _EditFrame(int TestTypeID)
        {
            switch (TestTypeID)
            {
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Eye.png");
                        lblTestName.Text = "Vision Test";
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Written.png");
                        lblTestName.Text = "Written Test";
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Street.png");
                        lblTestName.Text = "Street Test";
                        _IsStreetTest = true;
                        break;
                    }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            if (_TestAppointmentID < 0)
            {
                MessageBox.Show("The test appointment is locked , you can't take a test !");
                this.Close();
                return;
            }
          
            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
            if (_TestAppointment ==null)
            {
                MessageBox.Show("No test appointment with this ID !");
                this.Close();
                return;
            }
           _EditFrame(_TestTypeID);
            _LDLApp= clsLocalDrivingLicenseApplication.Find(_TestAppointment.LocalDrivingLicenseAppID);
            lblD_L_APPID.Text = _LDLApp.LocalDrivingLicenseID.ToString();
            lblClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLApp.LicenseClassID);
            lblFullName.Text = clsPerson.Find(clsApplications.Find(_LDLApp.ApplicationID).ApplicantPersonID).FullName;
            lblTrial.Text = (clsTestAppointments.NumberOfTrails(_LDLApp.LocalDrivingLicenseID, _TestTypeID) ).ToString();
            lblDate.Text = _TestAppointment.AppointmentDate.ToString("d");
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            _Test = new clsTests();

        }

        private bool _CheckResultBox()
        {
            return (rbFail.Checked || rbPass.Checked);
        }
        private bool _IsTestPass()
        {
            return (rbPass.Checked);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckResultBox())
            {
                MessageBox.Show("Test result was not specified ! ,It is essential");
                return; 
            }
            _Application = clsApplications.Find(clsLocalDrivingLicenseApplication.Find(_TestAppointment.LocalDrivingLicenseAppID).ApplicationID);
            if (_IsStreetTest && _IsTestPass()) 
            {
                _Application.ApplicationStatus = 3;
                if (!_Application.Save())
                {
                    MessageBox.Show("Status failed to change for [Completed] ,Something went wrong !","Fail");
                    return;
                }
            }
            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = _IsTestPass();
            _Test.Notes = txtbNotes.Text;
            _Test.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            _TestAppointment.IsLocked = true;
          
            if (_TestAppointment.RetakeTestApplicationID <1) 
            {
                _TestAppointment.RetakeTestApplicationID = null;
            }

            if (_TestAppointment.Save())
            {
                if (_Test.Save())
                {
                    lblTestID.Text = _Test.TestID.ToString();
                    MessageBox.Show("Test saved successfully...");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Test failed to save successfully...");
                    this.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Test appointment was not locked !");
                this.Close();
                return;
            }
          
        }
    }
}
