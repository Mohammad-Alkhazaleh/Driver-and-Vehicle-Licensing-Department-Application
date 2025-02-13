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
using DVLD_Buisness;
using NewDVLD_Project.General;
namespace NewDVLD_Project.Users
{
    public partial class ManageUsers : Form
    {
        private int _UserIDFromCellClick = 0;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private int _GetNumberOfRows(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshUsersData()
        {
            DataTable dt = clsUser.GetAllUsers();
            dgvUsers.DataSource = dt;
            lblNumRecords.Text =_GetNumberOfRows(dt).ToString();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Add_UpdateUser frm = new Add_UpdateUser();
            frm.ShowDialog();
            _RefreshUsersData();
        }

        private void tsAddNewUser_Click(object sender, EventArgs e)
        {
            Add_UpdateUser frm = new Add_UpdateUser();
            frm.ShowDialog();
            _RefreshUsersData();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Add_UpdateUser frm = new Add_UpdateUser(_UserIDFromCellClick);
            frm.ShowDialog();
            _RefreshUsersData();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // احصل على الصف المحدد
                DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];

                // احصل على أول عنصر في الصف (القيمة في العمود الأول)
                var firstCellValue = selectedRow.Cells[0].Value;

                // تحقق من القيمة (يمكن أن تكون Null)
                if (firstCellValue != null)
                {
                    _UserIDFromCellClick = (int)firstCellValue;
                }
                else
                {
                    MessageBox.Show("Right click on a boundary of table !");
                }
            }
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser(_UserIDFromCellClick))
            {
                _RefreshUsersData();
                MessageBox.Show("User deleted successfully...","Success");
            }
            else
            {
                MessageBox.Show("User failed to delete successfully...", "Fail");
            }
            
        }

        private void tsChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(_UserIDFromCellClick);
            frm.ShowDialog();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            ShowUserDetails frm = new ShowUserDetails(_UserIDFromCellClick);
            frm.ShowDialog();
        }
    }
}
