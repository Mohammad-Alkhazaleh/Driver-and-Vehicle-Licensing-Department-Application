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

namespace NewDVLD_Project.People
{
    public partial class ucPersonInformation : UserControl
    {
        private clsPerson _Person;
        public ucPersonInformation()
        {
            InitializeComponent();
        }
        private string ConvertNumberToGender(short Num)
        {
            return (Num == 0 ? "Male" : "Female");
        }
        public void FillLabelsWithData(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            lbl_PersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = ConvertNumberToGender(_Person.Gender);
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            pbImage.ImageLocation = _Person.ImagePath;

        }

        public void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_UpdatePerson frm = new Add_UpdatePerson(_Person.PersonID);
            frm.DataBack += FillLabelsWithData;
            frm.ShowDialog();
        }

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
