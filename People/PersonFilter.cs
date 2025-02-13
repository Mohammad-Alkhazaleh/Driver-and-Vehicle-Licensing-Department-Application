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
    public partial class PersonFilter : UserControl
    {
        public event Action<int> OnPersonFound;
        private clsPerson _Person = new clsPerson();
        public PersonFilter()
        {
            InitializeComponent();
        }

        private void pbSearchUser_Click(object sender, EventArgs e)
        {
            if (mtxtbFind.Text != string.Empty)
            {
                if (combItems.SelectedIndex == 0)
                {
                    _Person = clsPerson.Find(Convert.ToInt32(mtxtbFind.Text.Trim()));
                    if (_Person != null)
                    {
                        OnPersonFound?.Invoke(_Person.PersonID);
                    }
                    else
                    {
                        MessageBox.Show("There is no person with this ID !");
                    }
                }

                else if (combItems.SelectedIndex == 1)
                {
                    _Person = clsPerson.Find(mtxtbFind.Text.Trim());
                    if (_Person != null)
                    {
                        OnPersonFound?.Invoke(_Person.PersonID);
                    }
                    else
                    {
                        MessageBox.Show("There is no person with this NationalNo !");
                    }

                }
            }
        }

        private void PersonFilter_Load(object sender, EventArgs e)
        {
            combItems.SelectedIndex = 0;
        }

        private void mtxtbFind_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtbFind_Click(object sender, EventArgs e)
        {
            if (combItems.SelectedIndex == 0)
            {
                mtxtbFind.Mask = "00000";
            }
            else if (combItems.SelectedItem.ToString() == "Phone")
            {
                mtxtbFind.Mask = "000 - 0000";
            }
            else
            {

            }
        }
    }
} 

