using ApplicationBusinessLayer14;
using DriverBusinessLayer;
using DVLDBusinessLayer;
using LicenseClassesBusinessLayer;
using LicensesBusinessLayer;
using LocalDrivingApplicationBusinessLayer;
using PeopleBusinessLayer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;

namespace مشروع_كورس_19
{ 
    
    public partial class RenewLocalDrivingLicense : Form
    {

        int LicenseID = 0;
        public RenewLocalDrivingLicense()
        {
            InitializeComponent();
            filterLicense1.NumberUntilChoeseBetweenScreen = 1;
            filterLicense1.DataBack2 += HandleData;
            filterLicense1.DataBack3 += HandleData2;
         }
        
   
    private void HandleData(object sender, int LicenseID)
        {
          this.LicenseID = LicenseID;
            BtIssue.Enabled = false;
            ShowLicenseHistory.Enabled = true;
           applicationNewLicenseInfo1.StoreTheDataInControlWhenIhaveLicenseID(LicenseID);
         


    }


        private void HandleData2(object sender  , int LicenseID)
        {
            this .LicenseID = LicenseID;    
            BtIssue.Enabled = true;
            ShowLicenseHistory.Enabled = true;
            applicationNewLicenseInfo1.StoreTheDataInControlWhenIhaveLicenseID(LicenseID);


        }
       


        private void RenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            applicationNewLicenseInfo1.StoreTheDataInControl();

        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            // إعداد يدوي للموقع
            LicenseHistory frm = new LicenseHistory(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }
        private void AddNewLicense()
        {
            ShowNewLicenseInfo.Enabled = true;
            int LicenseID = this.LicenseID;
            int PersonID = People.GetPersonIDByLicenseID(LicenseID);
            int DriverID=  Driver.GetDriverIDByPersonID(PersonID);
     
            int ApplicationID = Application14.AddNewApplication(PersonID, DateTime.Now, 2, 3, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), Application14.GetFeesApplicationByApplicationTypeID(2));

            MessageBox.Show(ApplicationID.ToString());
            applicationNewLicenseInfo1.StoreTheApplicationID(ApplicationID);

   

           


            LicenseID = Licenses.AddNewLicense(ApplicationID, DriverID
                 , Licenses.GetLicenseClassByLicenseID(LicenseID), DateTime.Now,DateTime.Now.AddYears(LicenseClasses.GetDefaultValidityLengthByLicenseID(LicenseID))
               , applicationNewLicenseInfo1.Notes(),
                LicenseClasses.GetTheClassFeesByLicenseClass(Licenses.GetLicenseClassByLicenseID(LicenseID)), 1,2,

                  User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));
            applicationNewLicenseInfo1.StoreTheLicenseIDNew(LicenseID);
            Licenses.UpdatePersonInfo(this.LicenseID);

            this.LicenseID= LicenseID;

            MessageBox.Show(
    $"Licensed Renewed Successfully with ID={LicenseID}",
    "License Issued",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }
        private void BtIssue_Click(object sender, EventArgs e)
        {

            BtIssue.Enabled = false;

            DialogResult result = MessageBox.Show(
    "Are you sure you want to Renew the license?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddNewLicense();
            }
            else
            {
                // إلغاء أو عدم تنفيذ التجديد
            }



        }

        private void ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

          LicenseInfo frm = new LicenseInfo(0,LicenseID);
                frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

