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
    public partial class SchedualTest : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApp;
        private int _TestTypeID;
        private int _LDLAppID;
        private bool _IsRetake;
        private enum enMode { AddNew, Update}
        private enMode _Mode;
        private clsTestAppointments _TestAppointment;
        private int _TestAppointmentID;
        public SchedualTest(int LDLAppID,int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
            _LDLAppID = LDLAppID;
            _Mode = enMode.AddNew;
        }
        public SchedualTest(int LDLAppID, int TestTypeID ,int TestAppointment)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
            _LDLAppID = LDLAppID;
            _Mode = enMode.Update;
            _TestAppointmentID = TestAppointment;
        }
        private void EditFrame(int TestTypeID ,bool IsRetake=false,int? RetakeID =null)
        {
            switch (TestTypeID)
            {
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Eye.png");
                        lblTestAppointments.Text = "Vision Test Appointments";
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Written.png");
                        lblTestAppointments.Text = "Written Test Appointments";
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Street.png");
                        lblTestAppointments.Text = "Street Test Appointments";
                        break;
                    }
                    
            }
            int TestFees = clsTestTypes.GetTestFeesByTestTypeID(_TestTypeID);
            int RetakeAppFees = 0;
            dtpAppointmentDate.Value = DateTime.Now;
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            lblD_L_APPID.Text = _LDLApp.LocalDrivingLicenseID.ToString();
            lblClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLApp.LicenseClassID);
            lblFullName.Text = clsPerson.Find(clsApplications.Find(_LDLApp.ApplicationID).ApplicantPersonID).FullName;
            lblFees.Text = TestFees.ToString();
            lblTrial.Text = (clsTestAppointments.NumberOfTrails(_LDLAppID, TestTypeID)+1).ToString();
            if (IsRetake)
            {
                RetakeAppFees = clsApplicationTypes.GetApplicationFeesByAppTitle("Retake Test");
                gbRetakeTestInfo.Enabled = true;
                lblRetakeAppFees.Text = RetakeAppFees.ToString();
               
                if (RetakeID !=-1 && RetakeID !=null) 
                {
                    lblRTestID.Text = RetakeID.ToString();
                } 
            }
            lblTotalFees.Text = (RetakeAppFees + TestFees).ToString();

        }
        private void SchedualTest_Load(object sender, EventArgs e)
        {
            if (_TestTypeID <0 || _LDLAppID<0)
            {
                MessageBox.Show("Invalid ID");
                this.Close();
                return;
            }
           
            if (clsTestAppointments.CheckAnyUnlockTestAppointments(_LDLAppID,_TestTypeID) && _Mode==enMode.AddNew)
            {
                MessageBox.Show("There is an unlock appointment !");
                this.Close();
                return;
            }
            if (clsTests.IsTestPass(_LDLAppID ,_TestTypeID))
            {
                MessageBox.Show("This test is passed , you can not retake an appointment !");
                this.Close();
                return;
            }
            if (_Mode == enMode.AddNew)
            {
                _TestAppointment = new clsTestAppointments();
                if (_IsRetake = clsTestAppointments.CheckAnyLockTestAppointments(_LDLAppID, _TestTypeID))
                {
                    EditFrame(_TestTypeID,true,-1);
                }
                else
                {
                    EditFrame(_TestTypeID);
                }
                return;
            }
            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
            if (_TestAppointment == null) 
            {
                MessageBox.Show("No test appointment with this ID ! ");
                return;
            }
            if ( _IsRetake = clsTestAppointments.CheckAnyLockTestAppointments(_LDLAppID, _TestTypeID))
            {
                EditFrame(_TestTypeID,true,_TestAppointment.RetakeTestApplicationID);
            }
            else
            {
                EditFrame(_TestTypeID);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to schedual Test ? ","Save",MessageBoxButtons.OK,MessageBoxIcon.Question);
            if (DialogResult != DialogResult.OK)
            {
                return;
            }
            if (_IsRetake && _Mode ==enMode.AddNew)
            {
                clsApplications _Application = new clsApplications();
                _Application.ApplicantPersonID = clsPerson.Find(clsApplications.Find(_LDLApp.ApplicationID).ApplicantPersonID).PersonID;
                _Application.ApplicationStatus = 1;
                _Application.ApplicationDate = DateTime.Now;
                _Application.ApplicationTypeID = clsApplicationTypes.GetApplicationTypeIDByAppTitle("Retake Test");
                _Application.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
                _Application.LastStatusDate = DateTime.Now;
                _Application.PaidFees = clsApplicationTypes.GetApplicationFeesByAppTitle("Retake Test");
                if (!_Application.Save())
                { 
                    MessageBox.Show("Application failed to save successfully...", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                lblRTestID.Text = _Application.ApplicationID.ToString();
            }
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.PaidFees = Convert.ToInt32(lblTotalFees.Text);
            _TestAppointment.LocalDrivingLicenseAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
            _TestAppointment.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            _TestAppointment.IsLocked = false;
            if (!_IsRetake)
            {
                _TestAppointment.RetakeTestApplicationID = null;
            }
            else
            {
                _TestAppointment.RetakeTestApplicationID = Convert.ToInt32(lblRTestID.Text);
            }
            if (_TestAppointment.Save())
            {
                MessageBox.Show("Test appointment saved successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Test appointment Failed to save successfully...", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
