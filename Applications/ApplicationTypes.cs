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
    public partial class ApplicationTypes : Form
    {
        private int _AppTypeID;
        public ApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _RefreshNumOfRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV()
        {
            DataTable dt = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = dt;
            lblNumRecords.Text = _RefreshNumOfRecords(dt).ToString();

        }
        private void ApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void tsEditApplicationType_Click(object sender, EventArgs e)
        {
            UpdateApplicationTypes frm = new UpdateApplicationTypes(_AppTypeID);
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void dgvApplicationTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                DataGridViewRow selectedRow = dgvApplicationTypes.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _AppTypeID = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
        }
    }
}
