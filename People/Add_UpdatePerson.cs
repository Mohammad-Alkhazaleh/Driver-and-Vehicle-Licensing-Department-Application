using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
namespace NewDVLD_Project.People
{
  
    public partial class Add_UpdatePerson : Form
    {
        public delegate void DataBackEventHandler(int PersonID);
        public DataBackEventHandler DataBack;
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        private enum enGender { Male = 0, Female = 1 }
        private enGender _Gender;

        private clsPerson _Person;
        private int _PersonID;
        public Add_UpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
           
        }
        public Add_UpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _LoadData()
        {
          
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with this ID = " + _PersonID, "Person not found", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            txtFName.Text = _Person.FirstName;
            txtSName.Text = _Person.SecondName;
            txtTName.Text = _Person.ThirdName;
            txtLName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtAddress.Text = _Person.Address;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            combCountry.SelectedIndex = combCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "" && _Person.ImagePath != null) {
                pbImage.ImageLocation = _Person.ImagePath;
                llRemove.Visible = true;
            }
            else
            {
                llRemove.Visible = false;
            }
        }
        private void Add_UpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefalitValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                combCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _ResetDefalitValues()
        {
            _FillCountriesInComboBox();
            rbMale.Checked = true;
            if (_Mode == enMode.AddNew)
            {
                lblAdd_EditPerson.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblAdd_EditPerson.Text = "Update Person";
            }
            if (rbMale.Checked)
            {
                pbImage.Image = Image.FromFile(@"D:\NewDVLD_Project\Male 512.png");
            }
            else
            {
                pbImage.Image = Image.FromFile(@"D:\NewDVLD_Project\Female 512.png");
            }
            llRemove.Visible = (pbImage.ImageLocation != null);
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);

            combCountry.SelectedIndex = combCountry.FindString("Jordan");
            txtFName.Text = "";
            txtSName.Text = "";
            txtTName.Text = "";
            txtLName.Text = "";
            txtNationalNo.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
           
        }

        private bool _HandlePersonImage()
        {
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid ! , put the mouse over red icon.");
                return;
            }
            if (!_HandlePersonImage())
                return;
            
            _Person.FirstName =txtFName.Text;
            _Person.SecondName =txtSName.Text;
            _Person.ThirdName =txtTName.Text;
            _Person.LastName = txtLName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpBirthDate.Value;
            _Person.NationalityCountryID = clsCountry.Find(combCountry.Text).CountryID;
            if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            if (rbFemale.Checked)
                _Person.Gender = (short)enGender.Female;
            if (pbImage.ImageLocation != null)
                _Person.ImagePath = pbImage.ImageLocation.ToString();
            else
                _Person.ImagePath = "";
            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblAdd_EditPerson.Text = "Update Person";
                MessageBox.Show("Data saved successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DataBack?.Invoke(_Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error : Data is not saved successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        private void _ValidateEmptyTextBox(object sender , CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim())) 
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp , "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }
        private void _txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmail.Text.Trim() == "")
                return;
            if (!clsValiation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail,"Invalid email address format");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }
        private void _NationalNoValidationg(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo,"This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
            if (txtNationalNo.Text.Trim() !=_Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo,"National No is used for another person");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }
        public class clsValiation
        {
            public static bool ValidateEmail(string Email)
            {
                var Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(Email, Pattern);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation==null)
            {
                pbImage.Image = Image.FromFile("D:\\NewDVLD_Project\\Male 512.png");
            }
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
            {
                pbImage.Image = Image.FromFile("D:\\NewDVLD_Project\\Female 512.png");
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog changePic = new OpenFileDialog();
             DialogResult result =changePic.ShowDialog();
            if (result ==DialogResult.OK)
            {
                pbImage.ImageLocation = changePic.FileName;
                llRemove.Visible = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
