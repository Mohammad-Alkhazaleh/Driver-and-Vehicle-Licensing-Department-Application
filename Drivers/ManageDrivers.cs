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

namespace NewDVLD_Project.Drivers
{
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();
        }
        private int _NumRescords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshDGV()
        {
            DataTable dt = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = dt;
           lblNumRecords.Text= _NumRescords(dt).ToString();
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
        }
    }
}
