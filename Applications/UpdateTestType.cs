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
    public partial class UpdateTestType : Form
    {
        private int _TestTypeID = 0;
        private clsTestTypes _TestType;
        public UpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillData()
        {
            lblID.Text = _TestType.TestTypeID.ToString();
            txtbTitle.Text = _TestType.TestTypeTitle;
            txtbDescription.Text = _TestType.TestTypeDescription ;
            txtbFees.Text = _TestType.TestTypeFees.ToString();
        }
        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            if (_TestTypeID <0)
            {
                MessageBox.Show("Invalid TesttypeID ! ");
                this.Close();
                return;
            }
            _TestType = clsTestTypes.Find(_TestTypeID);

            if (_TestType==null)
            {
                MessageBox.Show("No TestType with this ID ! ");
                this.Close();
                return;
            }
            _FillData();

        }
        private bool _IsTextChanged = false;
        private void txtbTitle_TextChanged(object sender, EventArgs e)
        {
            _IsTextChanged = true;
        }

        private void txtbDescription_TextChanged(object sender, EventArgs e)
        {
            _IsTextChanged = true;
        }

        private void txtbFees_TextChanged(object sender, EventArgs e)
        {
            _IsTextChanged = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsTextChanged)
            {
                MessageBox.Show("Didn't change any thing !");
                return;
            }
            if (txtbDescription.Text==string.Empty)
            {
                MessageBox.Show("Description box is empty");
                return;
            }
            if (txtbFees.Text == string.Empty)
            {
                MessageBox.Show("Fees box is empty");
                return;
            }
            if (txtbTitle.Text == string.Empty)
            {
                MessageBox.Show("Title box is empty");
                return;
            }
            decimal FeesIn = 0;

            if (decimal.TryParse(txtbFees.Text.Trim(), out decimal fees))
            {
                FeesIn = fees;
            }
            else
            {
                MessageBox.Show("Fees text box is have a non decimal value");
            }
            _TestType.TestTypeTitle = txtbTitle.Text;
            _TestType.TestTypeDescription = txtbDescription.Text;
            _TestType.TestTypeFees = FeesIn;
            if (_TestType.Save())
            {
                MessageBox.Show("Test type updated successfully...","Success");
            }
            else
            {
                MessageBox.Show("Test type fail to update successfully...","Fail");
            }

        }
    }
}
