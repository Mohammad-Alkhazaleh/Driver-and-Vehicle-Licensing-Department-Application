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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewDVLD_Project.General
{
    public partial class ChangePassword : Form
    {
        private int _UserID;
        private clsPerson _Person;
        private clsUser _User;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private string GetGender(short Num)
        {
            return (Num == 0) ? "Male" : "Female";
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
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (_UserID<1)
            {
                MessageBox.Show("Invalid UserID ! ");
                this.Close();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User ==null)
            {
                MessageBox.Show("This form is Empty! ","Empty Form");
                this.Close();
                return;
            }
            _Person = clsPerson.Find(_User.PersonID);
            ucPersonInformation1.FillLabelsWithData(_Person.PersonID);
            FillUserLabels();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_UpdatePerson frm = new Add_UpdatePerson(_Person.PersonID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _CheckTextBoxEmpty(System.Windows.Forms.TextBox txtBox)
        {
            if (txtBox.Text == string.Empty)
            {
                errorProvider1.SetError(txtBox,"Fill the box , please !");
                return true;
            }
            return false;
            
        }
        private bool _CheckPasswordConfirmation(string NewPass , string ConfirmPass)
        {
            if (NewPass != ConfirmPass)
            {
                return false;
            }
            return true;
        }
        private bool _CheckCurrentPassword(string CurrentPass)
        {
            if (CurrentPass != _User.Password)
            {
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
           if(_CheckTextBoxEmpty(txtbCurrentPass))
            {
                MessageBox.Show("Fill the box , please !");
                return;
            }
            if (_CheckTextBoxEmpty(txtbNewPass))
            {
                {
                    MessageBox.Show("Fill the box , please !");
                    return;
                }
            }
            if (_CheckTextBoxEmpty(txtbConfirmPass))
            {
                {
                    MessageBox.Show("Fill the box , please !");
                    return;
                }
            }
            if (!_CheckCurrentPassword(txtbCurrentPass.Text))
            {
                MessageBox.Show("The current password is not same as the right password !");
                errorProvider1.SetError(txtbCurrentPass,"Enter correct password !");
                return;
            }
            if(_CheckPasswordConfirmation(txtbNewPass.Text, txtbConfirmPass.Text))
            {
                MessageBox.Show("The new password is not same as the confirm password !");
                errorProvider1.SetError(txtbConfirmPass, "Enter correct password !");
                return;
            }
            _User.Password = txtbNewPass.Text;
            if (_User.Save())
            {
                MessageBox.Show("User updated successfully...","Success");
            }
            else
            {
                MessageBox.Show("User failed to update successfully...", "Fail");
            }
        }
    }
}
