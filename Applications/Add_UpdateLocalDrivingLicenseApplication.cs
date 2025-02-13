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
using static System.Net.Mime.MediaTypeNames;

namespace NewDVLD_Project.Applications
{
    public partial class Add_UpdateLocalDrivingLicenseApplication : Form
    {
      
        private enum enStatus { New =1 , Cancelled =2 , Completed=3};
        private clsApplications _Application;
        private int _LDLAppID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsPerson _Person;
        private enum enMode { AddNew,Update}
        private enMode _Mode;
      
        public Add_UpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ucPersonFilter1.OnPersonFound += ucPersonInformationWithNext1.FillLabelsWithData;
            ucPersonFilter1.OnPersonAdded += ucPersonInformationWithNext1.FillLabelsWithData;
            ucPersonInformationWithNext1.NextStep += NextStep;
            _Mode = enMode.AddNew;
        }
        
        public Add_UpdateLocalDrivingLicenseApplication(int LDLAppID)
        {
            InitializeComponent();
            ucPersonFilter1.OnPersonFound += ucPersonInformationWithNext1.FillLabelsWithData;
            ucPersonFilter1.OnPersonAdded += ucPersonInformationWithNext1.FillLabelsWithData;
            _LDLAppID = LDLAppID;
            _Mode = enMode.Update;
        }
        private bool IsPersonHasLDLApp(int PersonID, int AppTypeID, string ClassName, int ApplicationStatus)
        {
            return (clsLocalDrivingLicenseApplication.IsPersonHasLDLApp(PersonID, AppTypeID, ClassName,ApplicationStatus));
           
        }
        private void NextStep(int PersonID)
        {
            if (PersonID<0)
            {
                MessageBox.Show("Invalid PersonID !");
                return;
            }
            _Person = clsPerson.Find(PersonID);
            if (_Person ==null)
            { 
                MessageBox.Show("No person with this ID!");
                return;
            }

           
                FillPersonalInfo();
                tabControl1.SelectedIndex = 0;
        }
        private void Add_UpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (_Mode ==enMode.AddNew)
            {
                _LDLApp = new clsLocalDrivingLicenseApplication();
                _Person = new clsPerson();
                _Application = new clsApplications();
                return;
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            if (_LDLApp==null)
            {
                MessageBox.Show("No LDLApp with this ID !");
                this.Close();
                return;
            }
            _Application = clsApplications.Find(_LDLApp.ApplicationID);
            _Person = clsPerson.Find(_Application.ApplicantPersonID);
            ucPersonInformationWithNext1.FillLabelsWithData(_LDLAppID);
                       
        }
        private void FillPersonalInfo()
        {
            lblAppDate.Text = DateTime.Now.ToString("d");
            combLicneseClass.DataSource = clsLicenseClass.GetLicenseClassesName();
            combLicneseClass.SelectedIndex=0;
            lblAppFees.Text = clsApplicationTypes.GetApplicationFeesByAppTitle("New Local Driving License Service").ToString();
            lblCreatedBy.Text = clsUser.CurrentUserInfo.UserName;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int AppTypeID = clsApplicationTypes.GetApplicationTypeIDByAppTitle("New Local Driving License Service");
            if (_Person == null)
            {
                MessageBox.Show("Choose a person , please", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            DialogResult = MessageBox.Show("Do you want to save it ? ","Saving",MessageBoxButtons.OK,MessageBoxIcon.Question);

            if (DialogResult != DialogResult.OK)
            {
                return;
            }
            if (IsPersonHasLDLApp(_Person.PersonID, AppTypeID,combLicneseClass.SelectedValue.ToString(), (int)enStatus.Completed))
            {
                MessageBox.Show("Person already has local driving license !");
                return;
            }
            if (IsPersonHasLDLApp(_Person.PersonID, AppTypeID, combLicneseClass.SelectedValue.ToString(), (int)enStatus.New))
            {
                MessageBox.Show("Person already has new local driving license application !");
                return;
            }
            //تاكد من جمع الfees مش صحيح 
            _Application.ApplicantPersonID = _Person.PersonID;
            _Application.ApplicationDate = Convert.ToDateTime(lblAppDate.Text);
            _Application.ApplicationTypeID = AppTypeID;
            _Application.ApplicationStatus = (int)(enStatus.New);
            _Application.LastStatusDate = Convert.ToDateTime(DateTime.Now);
            _Application.PaidFees = Convert.ToInt32(lblAppFees.Text) + clsLicenseClass.GetLicenseClassFeesByName(combLicneseClass.SelectedValue.ToString()) ;
            _Application.CreatedByUserID = Convert.ToInt32(clsUser.CurrentUserInfo.UserID);
            if (_Application.Save())
            {
                _LDLApp.ApplicationID = _Application.ApplicationID;
                _LDLApp.LicenseClassID = clsLicenseClass.GetLicenseClassIDByName(combLicneseClass.Text);
                if (_LDLApp.Save())
                {
                    MessageBox.Show("Application saved successfully ! ", "Sccuess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDLApplicationID.Text = _LDLApp.LocalDrivingLicenseID.ToString();
                    _Mode = enMode.Update;
                    
                }
                else
                {
                    MessageBox.Show("Local Driving License Application failed to save ! ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Application failed to save ! ","Fail",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
