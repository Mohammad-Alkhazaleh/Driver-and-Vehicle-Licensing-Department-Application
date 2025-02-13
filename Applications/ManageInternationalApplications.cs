using DVLD_Buisness;
using NewDVLD_Project.Applications;
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

namespace NewDVLD_Project.Licenses
{
    
    public partial class ManageInternationalApplications : Form
    {
        private int _InternationalLicenseID;
        private clsInternationalLicenses _InternationalLicense;
        private clsApplications _Application;
        private clsPerson _Person;
        public ManageInternationalApplications()
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
            DataTable dt = clsInternationalLicenses.GetInternationalLicesnes();
            dgvInternationalDrivingLicense.DataSource = dt;
            lblNumRecords.Text = NumRecords(dt).ToString();

        }
        private void ManageInternationalApplications_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void tsShowPersonDetails_Click(object sender, EventArgs e)
        {
           
            ShowPersonDetails frm = new ShowPersonDetails(_Person.PersonID);
            frm.ShowDialog();
        }

        private void dgvInternationalDrivingLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                selectedRow = dgvInternationalDrivingLicense.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _InternationalLicenseID = (int)firstCellValue;

                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
                if (_InternationalLicenseID < 0)
                {
                    MessageBox.Show("Invalid internationl licnese ID !");
                    return;
                }
                _InternationalLicense = clsInternationalLicenses.Find(_InternationalLicenseID);
                if (_InternationalLicense == null)
                {
                    MessageBox.Show("No internationl licnese with this ID !");
                    return;
                }
                _Person = clsPerson.Find((_Application = clsApplications.Find(_InternationalLicense.ApplicationID)).ApplicantPersonID);
            }
        }

        private void tsShowLicesneDetails_Click(object sender, EventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(clsInternationalLicenses.GetLDLAppIdByInternationalLicenseID(_InternationalLicense.InternationLicenseID));
            frm.ShowDialog();
        }

        private void tsShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(clsInternationalLicenses.GetLDLAppIdByInternationalLicenseID(_InternationalLicenseID));
            frm.ShowDialog();
        }

        private void btnAddInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            Add_UpdateInternationalLicenseApplication frm = new Add_UpdateInternationalLicenseApplication();
            frm.ShowDialog();
            _RefreshDGV();
        }
    }
}
