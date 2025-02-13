using DVLD_Buisness;
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
using static System.Net.Mime.MediaTypeNames;

namespace NewDVLD_Project.Tests
{
    public partial class ucApplicationInfo : UserControl
    {
        private enum enStatus {New =1 ,Cancelled =2 , Completed=3 }
        private List<string> ListStatus = new List<string> { "New", "Cancelled", "Completed" };
        private clsApplications _Application;
        private clsPerson _Person;
        private clsUser _User;
        public ucApplicationInfo()
        {
            InitializeComponent();
        }

        public void FillApplicationInfo(int ApplicationID)
        {
            _Application = clsApplications.Find(ApplicationID);
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            _User = clsUser.Find(_Application.CreatedByUserID);
            lblID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = ListStatus[_Application.ApplicationStatus-1];
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = clsApplications.GetApplicationTypeByAppID(_Application.ApplicationID);
            lblApplicant.Text = _Person.FullName;
            lblDate.Text = _Application.ApplicationDate.ToString("d");
            lblStatusDate.Text = _Application.LastStatusDate.ToString("d");
            lblCreatedBy.Text = _User.UserName;
        }
        private void llVisionPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails frm = new ShowPersonDetails(_Person.PersonID);
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
