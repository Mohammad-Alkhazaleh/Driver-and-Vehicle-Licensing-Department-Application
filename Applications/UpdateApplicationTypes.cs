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
    public partial class UpdateApplicationTypes : Form
    {
        private int _ApplicationTypeID;
        private clsApplicationTypes _Apptype;
        public UpdateApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void UpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            IsTextChanged = false;
            if (_ApplicationTypeID <0)
            {
                MessageBox.Show("Invalid ApplicationTypeID");
                this.Close();
                return;  
            }
            _Apptype = clsApplicationTypes.Find(_ApplicationTypeID);
            if (_Apptype ==null)
            {
                MessageBox.Show("No Application type with this ID");
                this.Close();
                return;
            }
            lblID.Text = _Apptype.ApplicationTypeID.ToString();
            txtbTitle.Text = _Apptype.ApplicationTypeTitle;
            txtbFees.Text = _Apptype.ApplicationFees.ToString() ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsTextChanged)
            {
                MessageBox.Show("Nothing was changed");
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtbTitle.Text))
                {
                    if (!string.IsNullOrEmpty(txtbFees.Text))
                    {
                        _Apptype.ApplicationTypeTitle = txtbTitle.Text.Trim();
                        _Apptype.ApplicationFees = Convert.ToDecimal(txtbFees.Text.Trim());
                        if (_Apptype.Save())
                        {
                            MessageBox.Show("Application type updated successfully...");
                            IsTextChanged = false;
                        }
                        else
                        {
                            MessageBox.Show("Application type failed to update successfully...");
                        }

                    }
                }
            }
        }

        bool IsTextChanged = false;
        private void txtbTitle_TextChanged(object sender, EventArgs e)
        {
            IsTextChanged = true;
        }

        private void txtbFees_TextChanged(object sender, EventArgs e)
        {
            IsTextChanged = true;
        }
    }
}
