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
    public partial class ShowPersonDetails : Form
    {
        private int _PersonID;
        public ShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            
           
        }

        private void ShowPersonDetails_Load(object sender, EventArgs e)
        {
            if (_PersonID<0)
            {
                MessageBox.Show("Invalid PersonID !");
                this.Close();
                return;
            }
            ucPersonInformation1.FillLabelsWithData(_PersonID);
        }

        private void ucPersonInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
