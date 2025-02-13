using DVLD_Buisness;
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

namespace NewDVLD_Project.Users
{
   
    public partial class ShowUserDetails : Form
    {
        private clsUser _User;
        private clsPerson _Person;
        private int _UserID;
        public ShowUserDetails(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetIsActive(bool IsActive)
        {
            return (IsActive) ? "Yes" : "No";
        }
        private void FillUserLabels()
        {
            lblUserID.Text = _UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = GetIsActive(_User.IsActive);
        }
        private void ShowUserDetails_Load(object sender, EventArgs e)
        {
            if (_UserID < 1)
            {
                MessageBox.Show("Invalid UserID ! ");
                this.Close();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This form is Empty! ", "Empty Form");
                this.Close();
                return;
            }
            _Person = clsPerson.Find(_User.PersonID);
            ucPersonInformation1.FillLabelsWithData(_Person.PersonID);
            FillUserLabels();
        }
    }
}
