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

namespace NewDVLD_Project.Licenses
{
    public partial class ucInternationalLicenseFilter : UserControl
    {
        public event Action<int> OnLicenseFound;
        private clsLicenses _License;
        public ucInternationalLicenseFilter()
        {
            InitializeComponent();
        }

        private void pbSearchLicense_Click(object sender, EventArgs e)
        {
            if (mtxtbFind.Text != string.Empty)
            {
                
                _License =clsLicenses.Find(Convert.ToInt32(mtxtbFind.Text.Trim()));
                if (_License == null)
                {
                    MessageBox.Show("There is no license with this ID !");
                    return;
                }
              
                OnLicenseFound?.Invoke(_License.LicenseID);
            }
        }
    }
}
