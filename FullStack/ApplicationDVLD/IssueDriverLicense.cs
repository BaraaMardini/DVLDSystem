using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDrivingApplicationBusinessLayer;
using DriverBusinessLayer;
using UserBusinessLayer;
using LicensesBusinessLayer;
using ApplicationBusinessLayer14;
using LicenseClassesBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class IssueDriverLicense : Form
    {
        int LocalDriveApplicationID = 0;
        string ClassName = "";
        public IssueDriverLicense(int LocalDriveApplicationID, string ClassName)
        {
            InitializeComponent();
            this.LocalDriveApplicationID = LocalDriveApplicationID; 
            this.ClassName = ClassName;
        }

        private void IssueDriverLicense_Load(object sender, EventArgs e)
        {
            localDriveApplicationDetails1.LocalDriveApplicationID = LocalDriveApplicationID;

            localDriveApplicationDetails1.UpdateDisplay();
        }
        private void AddNewLicense()
        {
            int LicenseID = 0;
            int DriverID = 0;
            int PersonID = LocalDrivingApplication.GetPersonIDByLocalDrivingApplicationID(LocalDriveApplicationID);
            int ApplicationID= LocalDrivingApplication.GetApplicationIDByLocalDriveApplicationID(LocalDriveApplicationID);
            MessageBox.Show(ApplicationID.ToString());
            if (DVLD.IsThePersonDrive(PersonID))
            {
                DriverID=Driver.GetDriverIDByPersonID(PersonID);
            }
            else
            {
                DriverID=Driver.AddNewDriver(PersonID,User.GetUserIDByUserNameAndPassword(UserInfo.UserName,UserInfo.Password),DateTime.Now);
            }


          
           


                LicenseID = Licenses.AddNewLicense(ApplicationID, DriverID
                     , LicenseClasses.GetTheLicenseClassIDByClassName(ClassName), DateTime.Now,
                     DateTime.Now.AddYears(LicenseClasses.GetDefaultValidityLengthByClassName(ClassName)), TbNotes.Text,
                     LicenseClasses.GetTheClassFeesByLocalDrivingLicenseApplicationID(LocalDriveApplicationID),
                     1, 1, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));

            
            if (LicenseID == -1)
            {

            }
            else
            {
                Application14.UpdateStatusAndLastStatusDate(ApplicationID, 3, DateTime.Now);
                MessageBox.Show("العملية تمت بنجاح");

            }





        }








        private void BtSave_Click(object sender, EventArgs e)
        {
            AddNewLicense();

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localDriveApplicationDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
