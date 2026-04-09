using ApplicationBusinessLayer14;
using DriverBusinessLayer;
using LicenseClassesBusinessLayer;
using LicensesBusinessLayer;
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
    public partial class ReplacementForDamagedLicense : Form
    {
        int LicenseID = 0;
        public ReplacementForDamagedLicense()
        {
            InitializeComponent();
            filterLicense1.NumberUntilChoeseBetweenScreen = 2;
            filterLicense1.DataBack4 += HandleData;
            filterLicense1.DataBack5 += HandleData2;
        }

        private void ReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {
            applicationInfoForLicenseReplacement1.StoreDataInControl();
        }
       
         


    private void HandleData(object sender, int LicenseID)
    {
        this.LicenseID = LicenseID;
        BtIssue.Enabled = false;
        ShowLicenseHistory.Enabled = true;
        applicationInfoForLicenseReplacement1.StoreOldLicenseID(LicenseID);





    }
        private void HandleData2(object sender, int LicenseID)
        {
            this.LicenseID = LicenseID;
            BtIssue.Enabled = true;
            ShowLicenseHistory.Enabled = true;
            applicationInfoForLicenseReplacement1.StoreOldLicenseID(LicenseID);



        }
        private void RbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            applicationInfoForLicenseReplacement1.StoreValueOfApplicationFees((int)Application14.GetFeesApplicationByApplicationTypeID(4));
        }

        private void RbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            applicationInfoForLicenseReplacement1.StoreValueOfApplicationFees((int)Application14.GetFeesApplicationByApplicationTypeID(3));

        }
        
        private void CheakApplicationTypeAndAddNewLicense(int ApplicationType, int IssueReason)
        {

            ShowNewLicenseInfo.Enabled = true;
            int LicenseID = this.LicenseID;
            int PersonID = People.GetPersonIDByLicenseID(LicenseID);
            int DriverID = Driver.GetDriverIDByPersonID(PersonID);

            int ApplicationID = Application14.AddNewApplication(PersonID, DateTime.Now,ApplicationType, 3, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), Application14.GetFeesApplicationByApplicationTypeID(ApplicationType));

            MessageBox.Show(ApplicationID.ToString());
            applicationInfoForLicenseReplacement1.StoreApplicationID(ApplicationID);
       






            LicenseID = Licenses.AddNewLicense(ApplicationID, DriverID
                 , Licenses.GetLicenseClassByLicenseID(LicenseID), DateTime.Now, DateTime.Now.AddYears(LicenseClasses.GetDefaultValidityLengthByLicenseID(LicenseID))
               ,"",
                LicenseClasses.GetTheClassFeesByLicenseClass(Licenses.GetLicenseClassByLicenseID(LicenseID)), 1, IssueReason,

                  User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));

            applicationInfoForLicenseReplacement1.StoreNewLicenseID(LicenseID);
            
            Licenses.UpdatePersonInfo(this.LicenseID);

            this.LicenseID = LicenseID;

                            MessageBox.Show(
                             $"Licensed Renewed Successfully with ID={LicenseID}",
                             "License Issued",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);





        }
        private void AddNewLicense()

        {
            if (RbDamagedLicense.Checked == true)
            {
                CheakApplicationTypeAndAddNewLicense(4, 3);
            }

            if (RbLostLicense.Checked == true) {

                CheakApplicationTypeAndAddNewLicense(3, 4);
            }









        }
        private bool CheakOfTypeReasonIsCheak()
        {
            if (RbDamagedLicense.Checked != true && RbLostLicense.Checked != true)
            {
                MessageBox.Show(" عليك اختيار سبب اصدار رخصة جديدة");
                return true;
            }
            return false;
        }

        private void BtIssue_Click(object sender, EventArgs e)
        {
            if (CheakOfTypeReasonIsCheak())
            {

            }
            else
            {


                DialogResult result = MessageBox.Show(
        "Are you sure you want to Renew the license?",
        "Confirm",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    AddNewLicense();
                    BtIssue.Enabled = false;
                    ShowNewLicenseInfo.Enabled = true;
                    filterLicense1.EnabledFilter();
                }
                else
                {
                    // إلغاء أو عدم تنفيذ التجديد
                }
            }
           
        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistory frm = new LicenseHistory(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frm = new LicenseInfo(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
