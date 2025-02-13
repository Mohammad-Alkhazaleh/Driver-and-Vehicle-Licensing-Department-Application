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
    public partial class TestAppointments : Form
    {
        private int _LDLAppID;
        private int _TestTypeID;
        private bool _IsLock;
        private int _TestAppointmentID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        public TestAppointments(int LDLAppID, int TestTypeID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _TestTypeID = TestTypeID;
        }

        private void EditFrame(int TestTypeID)
        {
            switch (TestTypeID)
            {
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Eye.png");
                        lblTestName.Text = "Vision Test Appointments";
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Written.png");
                        lblTestName.Text = "Written Test Appointments";
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile("C:\\Users\\Dell\\OneDrive\\Desktop\\DVLD_Project\\Street.png");
                        lblTestName.Text = "Street Test Appointments";
                        break;
                    }
            }
        }
        private int _RefreshNumOfRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV(int LDLAppID, int TestTypeID)
        {
            DataTable dt = clsTestAppointments.GetAllTestAppointments(LDLAppID, TestTypeID);
            DGV_Appointments.DataSource = dt;
            lblNumRecords.Text = _RefreshNumOfRecords(dt).ToString();

        }
        private void TestAppointments_Load(object sender, EventArgs e)
        {
            if (_LDLAppID < 0)
            {
                MessageBox.Show("Invalid local driver license application ID ! ");
                this.Close();
                return;
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            if (_LDLApp == null)
            {
                MessageBox.Show("No local driver license application with this ID ");
                this.Close();
                return;
            }
            EditFrame(_TestTypeID);
            ucDrivingLicenseApplicationInfo1.FillDivingLicenseAppInfo(_LDLAppID);
            ucApplicationInfo1.FillApplicationInfo(_LDLApp.ApplicationID);
            _RefreshDGV(_LDLApp.LocalDrivingLicenseID, _TestTypeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVisionTestSchedual_Click(object sender, EventArgs e)
        {
            SchedualTest frm = new SchedualTest(_LDLAppID, _TestTypeID);
            frm.ShowDialog();
            _RefreshDGV(_LDLAppID, _TestTypeID);
        }

        private void tstakeTest_Click(object sender, EventArgs e)
        {
            if (_IsLock)
            {
                MessageBox.Show("The test appointment is locked , you can't take a test !");
                return;
            }
            TakeTest frm = new TakeTest(_TestAppointmentID,_TestTypeID);
            frm.ShowDialog();
            _RefreshDGV(_LDLAppID, _TestTypeID);
        }

        private void DGV_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                selectedRow = DGV_Appointments.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var LastCellValue = selectedRow.Cells[3].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (LastCellValue != null)
                {
                    _IsLock = (Convert.ToInt32(LastCellValue)== 1);
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
                var FirstCellValue = selectedRow.Cells[0].Value;
                if (FirstCellValue != null)
                {
                    _TestAppointmentID = Convert.ToInt32(FirstCellValue);
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            if (_IsLock)
            {
                MessageBox.Show("The test appointment is locked , you can't edit the appointment !");
                return;
            }
            if (_TestAppointmentID < 0)
            {
                MessageBox.Show("Invalid test appointment ID !");
                return;
            }
            SchedualTest frm = new SchedualTest(_LDLAppID,_TestTypeID,_TestAppointmentID);
            frm.ShowDialog();
            _RefreshDGV(_LDLAppID,_TestTypeID);
        }
    }
}
