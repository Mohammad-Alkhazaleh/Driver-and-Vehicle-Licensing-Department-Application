using DVLD_Buisness;
using NewDVLD_Project.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project.Detain
{
    public partial class Detain_License : Form
    {
        private clsLicenses _License;
        private clsDetainedLicense _DetainedLicense;
        private enum enMode { AddNew ,Update}
        private enMode _Mode;
        public Detain_License()
        {
            InitializeComponent();
            ucLicenseFilter1.OnLicenseFound += GetLicenseID;
            llShowLicesnesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
            _Mode = enMode.AddNew;
        }
        private void GetLicenseID(int LicenseID)
        {
            _License = clsLicenses.Find(LicenseID);
            ucDriverLicenseInfo1.FillData(LicenseID);
            lbl_Detain_LicesneID.Text = _License.LicenseID.ToString();
            if (_License == null)
            {
                llShowLicesnesHistory.Enabled = false;
                llShowNewLicensesInfo.Enabled = false;
            }
            else
            {
                llShowLicesnesHistory.Enabled = true;
                llShowNewLicensesInfo.Enabled = true;
            }
        }
        private void FillDetainInfo()
        {
            lblDetainDate.Text = DateTime.Now.ToString("d");
            lbl_R_CreatedBy.Text = clsUser.CurrentUserInfo.UserName;
        }
        private void Detain_License_Load(object sender, EventArgs e)
        {
            if (_Mode==enMode.AddNew)
            {
                _DetainedLicense = new clsDetainedLicense();
            }
            FillDetainInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicesnesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_License.LicenseID));
            frm.ShowDialog();
        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(clsLicenses.GetLocalDrivingLicenseID_ByLicenseID(_License.LicenseID));
            frm.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (clsDetainedLicense.IsLicenseDetained(_License.LicenseID))
            {
                MessageBox.Show("License is already detained !");
                return;
            }
            if (string.IsNullOrEmpty(txtbFineFees.Text))
            {
                MessageBox.Show("please enter a fine fees amount !");
                return;
            }
            if (_License ==null)
            {
                MessageBox.Show("please enter a license ID !");
                return;
            }
            _DetainedLicense.LicenseID = _License.LicenseID;
            _DetainedLicense.DetainDate = Convert.ToDateTime(lblDetainDate.Text);
            _DetainedLicense.CreatedByUserID = clsUser.CurrentUserInfo.UserID;
            _DetainedLicense.IsReleased = false;
            _DetainedLicense.ReleaseApplicationID = null;
            _DetainedLicense.FineFees = Convert.ToInt32(txtbFineFees.Text);
            _DetainedLicense.ReleaseDate = null;
            _DetainedLicense.ReleasedByUserID = null;
            if (_DetainedLicense.Save())
            {
                lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                MessageBox.Show("License is detained successfully !","Success");
            }
            else
            {
                MessageBox.Show("License is failed to detain successfully !", "Fail");
            }
        }
    }
}
