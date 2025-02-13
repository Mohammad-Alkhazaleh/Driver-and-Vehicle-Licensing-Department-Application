using DVLD_Buisness;
using NewDVLD_Project.Licenses;
using NewDVLD_Project.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project.Detain
{
    public partial class ManageDetainLicenses : Form
    {

        private int _DetainID;
        private int _LicenseID;
        private clsDetainedLicense _DetainLicense;
        private clsLicenses _License;
        public ManageDetainLicenses()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int NumRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV()
        {
            DataTable dt = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = dt;
            lblNumRecords.Text = NumRecords(dt).ToString();

        }
        private void ManageDetainLicenses_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                return;
            }
            ShowPersonDetails frm = new ShowPersonDetails(clsApplications.Find(_License.ApplicationID).ApplicantPersonID);
            frm.ShowDialog();
        }

        private void dgvDetainedLicenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                DataGridViewRow selectedRow = dgvDetainedLicenses.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _DetainID = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
                var SecondCellValue = selectedRow.Cells[1].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (SecondCellValue != null)
                {
                    _LicenseID = (int)SecondCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
            if ((_License = clsLicenses.Find(_LicenseID)) == null)
            {
                MessageBox.Show("please choose a valid license");
                return;
            }
        }

        private void tsAddNewPerson_Click(object sender, EventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(_License.LicenseID);
            frm.ShowDialog();
        }

        private void tsPersonLicneseHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_LicenseID));
            frm.ShowDialog();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense(_License.LicenseID);
            frm.ShowDialog();
        }
    }
}
