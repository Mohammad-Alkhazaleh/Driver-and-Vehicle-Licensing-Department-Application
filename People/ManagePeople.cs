using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NewDVLD_Project.People
{
    public partial class ManagePeople : Form
    {
        private int _PersonID;
        public ManagePeople()
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
            DataTable dt = clsPerson.GetAllPeople();
            dgvPeople.DataSource = dt;
            lblNumRecords.Text = _RefreshNumOfRecords(dt).ToString();

        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Add_UpdatePerson frm = new Add_UpdatePerson();
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            ShowPersonDetails frm = new ShowPersonDetails(_PersonID);
            frm.ShowDialog();
        }

        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                DataGridViewRow selectedRow = dgvPeople.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _PersonID = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
        }

        private void tsAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_UpdatePerson frm = new Add_UpdatePerson();
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Add_UpdatePerson frm = new Add_UpdatePerson(_PersonID);
            frm.ShowDialog();
            _RefreshDGV();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (_PersonID <0)
            {
                MessageBox.Show("Invalid PersonID ! ");
                this.Close();
                return;
            }
            if(clsPerson.DeletePerson(_PersonID))
            {
                MessageBox.Show("Person deleted successfully...","Success");
                _RefreshDGV();
            }
            else
            {
                MessageBox.Show("Person failed to delete successfully...","Fail");
            }
        }
    }
}
