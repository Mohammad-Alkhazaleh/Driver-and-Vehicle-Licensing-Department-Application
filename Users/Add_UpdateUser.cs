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
    public partial class Add_UpdateUser : Form
    {
        private int _PersonID;
        private int _UserID;
        private clsPerson _Person;
        private clsUser _User;
        private enum enMode { AddNew , Update}
        private enMode _Mode;
        public Add_UpdateUser()
        {
            InitializeComponent();
            
            ucPersonFilter1.OnPersonFound += ucPersonInformation1.FillLabelsWithData;
            ucPersonInformation1.NextStep += NextStep;
            tabControl1.SelectedIndex = 1;
            _Mode = enMode.AddNew;
        }
        public Add_UpdateUser(int UserID)
        {
            InitializeComponent();
            ucPersonInformation1.NextStep += NextStep;
            tabControl1.SelectedIndex = 1;
            _UserID = UserID;
            _Mode = enMode.Update;
        }
        private bool IsPersonHasUser(int PersonID)
        {
            return clsUser.IsPersonHasUser(PersonID);
        }
        private void NextStep(int PersonID)
        {
            if (IsPersonHasUser(PersonID) && _Mode==enMode.AddNew)
            {
                MessageBox.Show("Person already has user !");
                return;
            }
            _PersonID = PersonID;
            _Person = clsPerson.Find(_PersonID);
            tabControl1.SelectedIndex = 0;
        }
        private void FillUserData()
        {
            txtbUserName.Text = _User.UserName;
            txtbPassword.Text = _User.Password;
            txtbConfirmPass.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;
            lblUserID.Text = _User.UserID.ToString();
        }
        private void AddNewUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                lblAdd_EditUser.Text = "Add New User";
                return; 
            }
            if (_UserID < 0 || !clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show("No user with this ID ! ");
                this.Close();
                return; 
            }
            
            _User = clsUser.Find(_UserID);
            if (_User ==null)
            {
                MessageBox.Show("No user with this ID ! ");
                this.Close();
                return;
            }
            _Person = clsPerson.Find(_User.PersonID);
            ucPersonInformation1.FillLabelsWithData(_Person.PersonID);
            FillUserData();
            _Mode = enMode.Update;
            lblAdd_EditUser.Text = "Update User";

        }

        private void ucPersonInformation1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorProviderTxtBox(TextBox txtBox)
        {
            if (txtBox.Text == string.Empty)
            {
                errPr.SetError(txtBox,"Fill the box ,please");
                return;
            }
            errPr.Clear();
           
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            ErrorProviderTxtBox(txtbUserName);
            ErrorProviderTxtBox(txtbPassword);
            ErrorProviderTxtBox(txtbConfirmPass);


            if (!clsPerson.IsPersonExist(_Person.PersonID) )
            {
                MessageBox.Show("You should select a person before this step ! ");
                return;
            }
            else if (txtbUserName.Text.Trim() ==string.Empty || txtbPassword.Text==string.Empty || txtbConfirmPass.Text ==string.Empty )
            {
                MessageBox.Show("You should fill the empty boxes ! ");
                return;
            }
            if (_Mode ==enMode.Update)
            {
                _User.UserID = _UserID;
            }
            _User.UserName = txtbUserName.Text.Trim();
            _User.PersonID = _Person.PersonID;
            _User.Password = txtbPassword.Text.Trim();
            _User.IsActive = cbIsActive.Checked;
            if (_User.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    lblAdd_EditUser.Text = "Update User";
                    lblUserID.Text = _User.UserID.ToString();
                    _Mode = enMode.Update;
                    MessageBox.Show("User added successfully...", "Success"); 
                }
                else
                {
                    lblAdd_EditUser.Text = "Update User";
                    MessageBox.Show("User updated successfully...", "Success");
                }
            }
            else
            {
                MessageBox.Show("User failed to add successfully...", "Fail");
            }

        }
    }
}
