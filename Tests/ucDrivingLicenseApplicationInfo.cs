using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDVLD_Project.Tests
{
    public partial class ucDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApp;
        private enum enTestName {VisionTest=1 , WrittenTest=2, StreetTest =3 }
        public ucDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public int CountOfPassedTests()
        {
            int Counter = 0;
            if (clsTests.IsTestPass( _LDLApp.LocalDrivingLicenseID, (int)enTestName.VisionTest))
            {
                Counter ++;
            }
            if (clsTests.IsTestPass( _LDLApp.LocalDrivingLicenseID , (int)enTestName.WrittenTest))
            {
                Counter++;
            }
            if (clsTests.IsTestPass( _LDLApp.LocalDrivingLicenseID , (int)enTestName.StreetTest))
            {
                Counter++;
            }
            return Counter;
        }
        public void FillDivingLicenseAppInfo(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            lblD_L_APPID.Text = _LDLApp.LocalDrivingLicenseID.ToString();
            lblAppliedForLicense.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLApp.LicenseClassID);
            lblPassedTests.Text = $"[{CountOfPassedTests().ToString()}/3]";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
