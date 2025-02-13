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

namespace NewDVLD_Project.Users
{
    public partial class LoginScreen : Form
    {
       
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtbPassword.Text))
                {
                    if (clsUser.IsUserExist_Active(txtbUserName.Text.Trim(), txtbPassword.Text.Trim()))
                    {
                        clsUser.CurrentUserInfo= clsUser.FindByUserName_Pass(txtbUserName.Text.Trim(), txtbPassword.Text.Trim()); 
                        if (!cbRememberMe.Checked)
                        {
                            txtbUserName.Text = string.Empty;
                            txtbPassword.Text = string.Empty;
                        }
                        FrmMain frm = new FrmMain(this);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username , password , Try again ! ");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtbPassword,"This field is required !");
                }
            }
            else
            {
                errorProvider1.SetError(txtbPassword, "This field is required !");
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
