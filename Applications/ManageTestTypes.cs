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

namespace NewDVLD_Project.Applications
{
    public partial class ManageTestTypes : Form
    {
        private int _TestTypeID=0;
        public ManageTestTypes()
        {
            InitializeComponent();
        }
        private int _RefreshNumOfRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV()
        {
            DataTable dt = clsTestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = dt;
            lblNumRecords.Text = _RefreshNumOfRecords(dt).ToString();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void tseditTestType_Click(object sender, EventArgs e)
        {
            UpdateTestType frm = new UpdateTestType(_TestTypeID);
            frm.Show();
            _RefreshDGV();
        }

        private void dgvTestTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                DataGridViewRow selectedRow = dgvTestTypes.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _TestTypeID = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
        }
    }
}
