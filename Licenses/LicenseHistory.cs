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
    public partial class LicenseHistory : Form
    {
        private int _LDLAppID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsPerson _Person;
        public LicenseHistory(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            personFilter1.OnPersonFound += ucPersonInformation1.FillLabelsWithData;
            personFilter1.OnPersonFound += _RefreshLocalLicensesDGV;
            personFilter1.OnPersonFound += _RefreshInternationalLicensesDGV;
        }

        private int _NumOfRecords(DataTable dt)
        {
            return dt.Rows.Count;
        }
        private void _RefreshLocalLicensesDGV(int PersonID)
        {
            DataTable dt = clsLicenses.GetAllLocalLicenses(PersonID);
            dgvLocalLicenseHistory.DataSource = dt;
            lblRecords.Text = _NumOfRecords(dt).ToString();
        }
        private void _RefreshInternationalLicensesDGV(int PersonID)
        {
            DataTable dt = clsLicenses.GetAllInternationalLicenses(PersonID);
            dgvInternationalLicenseHistory.DataSource = dt;
            lblRecords.Text = _NumOfRecords(dt).ToString();
        }
        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            if (_LDLAppID <0)
            {
                MessageBox.Show("Invalid local driving license application ID !");
                this.Close();
                return;
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            if (_LDLApp ==null)
            {
                MessageBox.Show("No local driving license application with this ID !");
                this.Close();
                return;
            }
            _Person = clsPerson.Find(clsApplications.Find(_LDLApp.ApplicationID).ApplicantPersonID);
            if (_Person == null)
            {
                MessageBox.Show("No person with this ID !");
                this.Close();
                return;
            }
            ucPersonInformation1.FillLabelsWithData(_Person.PersonID);
            tabControl1.SelectedIndex = 0;
            _RefreshLocalLicensesDGV(_Person.PersonID);


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                _RefreshLocalLicensesDGV(_Person.PersonID);
            }
            else
            {
                _RefreshInternationalLicensesDGV(_Person.PersonID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
