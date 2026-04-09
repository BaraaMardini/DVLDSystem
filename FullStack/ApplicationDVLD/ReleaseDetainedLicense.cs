using ApplicationBusinessLayer14;
using DetainedLicensesBusinessLayer;
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
    public partial class ReleaseDetainedLicense : Form
    {

        int LicenseID = 0;
        public ReleaseDetainedLicense(int LicenseID)
        {

     
            InitializeComponent();
            if (LicenseID != 0)

            {
                this.LicenseID = LicenseID;
                
                ApplyLicenseFilter(LicenseID);
            }

            filterLicense1.NumberUntilChoeseBetweenScreen = 4;
            filterLicense1.DataBack8 += HandleData;
            filterLicense1.DataBack9 += HandleData2; 
        }



        private void ApplyLicenseFilter(int LicenseID)
        {
            filterLicense1.StoreLicenseIDInTbFilter(LicenseID);
            filterLicense1.EnabledFilter();
            filterLicense1.SendTheDataInControlDriveLicense();

            BtRelease.Enabled = true;
            ShowLicenseHistory.Enabled = true;
            detainInfo21.LicenseID = LicenseID;



            detainInfo21.StoreDataInControl();
        }

    private void HandleData(object sender, int LicenseID)
    {
        this.LicenseID = LicenseID;
        BtRelease.Enabled = false;
        ShowLicenseHistory.Enabled = true;
     
            detainInfo21.StoreLicenseID(LicenseID);

    }



        private void HandleData2(object sender, int LicenseID)
        {
            this.LicenseID = LicenseID;
            BtRelease.Enabled = true;
            ShowLicenseHistory.Enabled = true;
            detainInfo21.LicenseID = LicenseID;



            detainInfo21.StoreDataInControl();
            

        }


        private void ReleaseDetainedLicense1()
        {

            DialogResult result = MessageBox.Show(
    "Are you sure you want to Release this license?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int ApplicationID = Application14.
                    AddNewApplication(People.GetPersonIDByLicenseID(LicenseID), DateTime.Now, 5,3
                    , DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), Application14.GetFeesApplicationByApplicationTypeID(5)) ;
                MessageBox.Show(ApplicationID.ToString());
                detainInfo21.StoreTheApplicationID(ApplicationID);
                DetainedLicenses.UpdateDetainLicense(1, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), ApplicationID,detainInfo21.GetDetainID());











          
                MessageBox.Show(
                    "Detained License Released Successfully",
                    "Detained License Released",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                BtRelease.Enabled=false;
                filterLicense1.EnabledFilter();
                ShowNewLicenseInfo.Enabled = true ;
            }
            else
            {
                // المستخدم اختار "No"
                // ضع هنا الكود اللازم عند الرفض
            }




        }


        private void ReleaseDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void BtRelease_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense1();
        }

        private void ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void filterLicense1_Load(object sender, EventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
