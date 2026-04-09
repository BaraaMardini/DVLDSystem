using ApplicationBusinessLayer14;
using DriverBusinessLayer;
using DVLDBusinessLayer;
using InternationalLicensesBusinessLayer;
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
    public partial class NewInternationalLicenseApplication : Form
    {
        int LicenseID = 0;
        int InternationalLicenseID = 0;
     
        public NewInternationalLicenseApplication()
        {
            InitializeComponent();
            filterLicense1.NumberUntilChoeseBetweenScreen = 0;
            filterLicense1.DataBack += HandleData;
            filterLicense1.DataBack10 += HandleData2;
        }

        private void HandleData(object sender, int LicenseID)
        {
            applicationInfo1.StoreTheLicenseID(LicenseID);
            this.LicenseID = LicenseID;
            BtIssue.Enabled = true;
            ShowLicenseHistory.Enabled = true;


        }

        private void HandleData2(object sender, int LicenseID)
        {
            applicationInfo1.StoreTheLicenseID(LicenseID);
            this.LicenseID = LicenseID;
            BtIssue.Enabled = false;
            ShowLicenseHistory.Enabled = false;


        }
        private void NewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            applicationInfo1.StoreTheDataInControl(); 
          
            

        }
        private void AddNewInternationalLicense()
        {

            int PersonID=People.GetPersonIDByLicenseID(LicenseID);
            MessageBox.Show(PersonID.ToString());
          int ApplicationID=  Application14.AddNewApplication(PersonID, DateTime.Now, 6,3, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password),Application14.GetFeesApplicationByApplicationTypeID(6));
            MessageBox.Show(ApplicationID.ToString());
            int InternationalLicenseID = InternationalLicenses.AddNewInternationalLicense(ApplicationID, LicenseID, 1, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), DateTime.Now.AddYears(1), Driver.GetDriverIDByPersonID(PersonID)) ;
            MessageBox.Show(InternationalLicenseID.ToString());
            applicationInfo1.StoreTheDataAfterConstructionInternationalLicense(ApplicationID, InternationalLicenseID);
            MessageBox.Show(LicenseID.ToString());
            BtIssue.Enabled= false;
            ShowLicenseInfo.Enabled = true ;
            filterLicense1.EnabledFilter();
            this.InternationalLicenseID=InternationalLicenseID;



        }
        private bool CheakIfCanIssueInternationalLicense()
        {
            int LicenseID = filterLicense1.GetLicenseID();

           




            this.LicenseID = LicenseID;
            if (InternationalLicenses.FindTheInternationalLicenseByLicenseID(LicenseID))
            {
                MessageBox.Show("هذا الشخص لديه رخصة عالمية بالفعل  وفعالة لذا لا يمكنك اصدار رخصة جديدة ");

                return false;
            }

            if (!Licenses.CheckClass3LocalLicense(LicenseID))
            {
                MessageBox.Show("     لا يمكن اصدار رخصة دولية لان هذا الشخص لا يتمتلك رخصة محلية من النوع   Ordinary driving license   ");

                return false;
            }
            if (filterLicense1.IsActive() == "No")
            {
                MessageBox.Show("لا يمكن انشاء رخصة لان الرخصة المحلية غير فعالة ");

                return false;
            }

           

                AddNewInternationalLicense();
                return true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheakIfCanIssueInternationalLicense();
        }

        private void filterLicense1_Load(object sender, EventArgs e)
        {
         

        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              

            // إعداد يدوي للموقع
            LicenseHistory frm = new LicenseHistory(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }
    

        private void ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InternationalDriverInfo frm = new InternationalDriverInfo(InternationalLicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
