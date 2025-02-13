using DVLD_Buisness;
using NewDVLD_Project.Applications;
using NewDVLD_Project.Detain;
using NewDVLD_Project.Drivers;
using NewDVLD_Project.General;
using NewDVLD_Project.Licenses;
using NewDVLD_Project.People;
using NewDVLD_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project
{
    public partial class FrmMain : Form
    {
        private LoginScreen _Loginfrm;
        public FrmMain(LoginScreen loginfrm)
        {
            InitializeComponent();
            _Loginfrm = loginfrm;
        }

        private void tsSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            _Loginfrm.Show();
        }

        private void tsUsers_Click(object sender, EventArgs e)
        {
            ManageUsers frm = new ManageUsers();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails frm = new ShowUserDetails(clsUser.CurrentUserInfo.UserID);
            //يوجد مشكله هنا 
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(clsUser.CurrentUserInfo.UserID);
            frm.ShowDialog();
        }

        private void manageTextTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes frm = new ManageTestTypes();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypes frm = new ApplicationTypes();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople frm = new ManagePeople();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_UpdateLocalDrivingLicenseApplication frm = new Add_UpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplications frm = new ManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalApplications frm = new ManageInternationalApplications();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDrivers frm = new ManageDrivers();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detain_License frm = new Detain_License();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainLicenses frm = new ManageDetainLicenses();
            frm.ShowDialog();
        }

        private void renewDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewDrivingApplication frm = new RenewDrivingApplication();
            frm.ShowDialog();
        }

        private void replacmentForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacmentForLostOrDamaged frm = new ReplacmentForLostOrDamaged();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
