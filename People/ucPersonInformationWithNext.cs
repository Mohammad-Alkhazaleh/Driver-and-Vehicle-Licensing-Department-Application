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
    public partial class ucPersonInformationWithNext : UserControl
    {
        private int _PersonID;
        private clsPerson _Person;
        public event Action<int> NextStep;
        
        //هنا يوجد مشكله بالحدث لم ازبطه 
        public ucPersonInformationWithNext()
        {
            InitializeComponent();
             
        }
      
        private string ConvertNumberToGender(short Num)
        {
            return (Num==0?"Male" : "Female");
        }
        private void ucPersonInformation_Load(object sender , EventArgs e)
        {
            
        }
        public void FillLabelsWithData(int PersonID)
        {
            if (PersonID < 0)
            {
                MessageBox.Show("Invalid PersonID ! ");
                return;
            }
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Please choose a person!");
                return;
            }
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

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person !=null) {
                Add_UpdatePerson frm = new Add_UpdatePerson(_Person.PersonID);
                frm.DataBack += FillLabelsWithData;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a person!");
            }
        }

        //private void btnNext_Click(int PersonID)
        //{
        //    if (PersonID < 0)
        //    {
        //        MessageBox.Show("Invalid PersonID ! ");
        //        return;
        //    }
        //    _Person = clsPerson.Find(PersonID);
        //    if (_Person == null)
        //    {
        //        MessageBox.Show("Please choose a person!");
        //    }
        //    NextStep?.Invoke(_Person.PersonID);
        //}
       

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Please choose a person!");
                return;
            }
            NextStep?.Invoke(_Person.PersonID);
        }
    }
}
