using DVLD_Buisness;
using NewDVLD_Project.Licenses;
using NewDVLD_Project.Tests;
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
    
    public partial class ManageLocalDrivingLicenseApplications : Form
    {
        private int _LDLAppID = 0;
        private clsLocalDrivingLicenseApplication _LDLApp;
        public ManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private int _RefreshNumOfRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV()
        {
            DataTable dt = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenses();
            dgvLocalDrivingLicense.DataSource = dt;
            lblNumRecords.Text = _RefreshNumOfRecords(dt).ToString();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void btnAddLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            Add_UpdateLocalDrivingLicenseApplication frm = new Add_UpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void tscancelApplication_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure , Do you want to cancel the application ?","Cancel",MessageBoxButtons.OK,MessageBoxIcon.Question);
            if (DialogResult ==DialogResult.OK)
            {
                _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
                clsApplications _Application = clsApplications.Find(_LDLApp.ApplicationID);
                _Application.ApplicationStatus = 2;
                if(_Application.Save())
                {
                    MessageBox.Show("Application is cancelled successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDGV();
                }
                else
                {
                    MessageBox.Show("Application is failed to cancel successfully...", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
           
            
        }

        private void dgvLocalDrivingLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                 selectedRow = dgvLocalDrivingLicense.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _LDLAppID = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }

            showApplicationDetailsToolStripMenuItem.Enabled = true;
            tsEditApplication.Enabled = true;
            tsDeleteApplication.Enabled = true;
            tscancelApplication.Enabled = true;
            tsSechdualTest.Enabled = true;
            tsIssueDrivingLicenseFirstTime.Enabled = true;
            tsShowLicense.Enabled = true;
            tsShowPersonLicenseHistory.Enabled = true;
            tsSechdualWrittenTest.Enabled = true;
            tsSechdualStreetTest.Enabled = true;
            tsSechdualVisionTest.Enabled = true;

            var LastCellValue = selectedRow.Cells[6].Value.ToString();
            if ((LastCellValue == "Cancelled")) {
                tsDeleteApplication.Enabled = false;
                tsSechdualTest.Enabled = false;
                tsIssueDrivingLicenseFirstTime.Enabled = false;
                tsShowPersonLicenseHistory.Enabled = false;
                tsEditApplication.Enabled = false;
                tsShowLicense.Enabled = false;
                tscancelApplication.Enabled = false;
                }
            else if ((LastCellValue == "Completed"))
            {
                if (clsLicenses.IsLicenseExist(_LDLAppID)) {
                    tsSechdualTest.Enabled = false;
                    tsIssueDrivingLicenseFirstTime.Enabled = false;
                    tsDeleteApplication.Enabled = false;
                    tsEditApplication.Enabled = false;
                    tscancelApplication.Enabled = false;
                }
                else
                {
                    tsDeleteApplication.Enabled = false;
                    tsSechdualTest.Enabled = false;
                    tsShowLicense.Enabled = false;
                    tsEditApplication.Enabled = false;
                    tscancelApplication.Enabled = false;
                }
            }
            else
            {
                if (!clsTests.IsTestPass(_LDLAppID, 1))
                {
                
                    tsSechdualWrittenTest.Enabled = false;
                    tsSechdualStreetTest.Enabled = false;
                    tsIssueDrivingLicenseFirstTime.Enabled = false;
                    tsShowLicense.Enabled = false;
                    tsShowPersonLicenseHistory.Enabled = false;
                    return;
                }
                if (!clsTests.IsTestPass(_LDLAppID, 2))
                {
                    tsSechdualVisionTest.Enabled = false;
                    tsSechdualStreetTest.Enabled = false;
                    tsIssueDrivingLicenseFirstTime.Enabled = false;
                    tsShowLicense.Enabled = false;
                    tsShowPersonLicenseHistory.Enabled = false;
                    return;
                }
                if (!clsTests.IsTestPass(_LDLAppID, 3))
                {
                    tsSechdualVisionTest.Enabled = false;
                    tsSechdualWrittenTest.Enabled = false;
                    tsIssueDrivingLicenseFirstTime.Enabled = false;
                   tsShowLicense.Enabled = false;
                    tsShowPersonLicenseHistory.Enabled = false;
                    return;
                }
                else
                {
                    tsSechdualTest.Enabled = false;
                    tsShowLicense.Enabled = false;
                }
            }
        }

        private void tsSechdualVisionTest_Click(object sender, EventArgs e)
        {
            TestAppointments frm = new TestAppointments(_LDLAppID,1);
            frm.ShowDialog();
        }

        private void tsSechdualWrittenTest_Click(object sender, EventArgs e)
        {
            TestAppointments frm = new TestAppointments(_LDLAppID, 2);
            frm.ShowDialog();
        }

        private void tsSechdualStreetTest_Click(object sender, EventArgs e)
        {
            TestAppointments frm = new TestAppointments(_LDLAppID, 3);
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void tsIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
           IssueDrivingLicensesForTheFirstTime frm = new IssueDrivingLicensesForTheFirstTime(_LDLAppID);
            frm.ShowDialog();
        }

        private void tsShowLicense_Click(object sender, EventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(_LDLAppID);
            frm.ShowDialog();
        }

        private void tsShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(_LDLAppID);
            frm.ShowDialog();
        }
    }
}
