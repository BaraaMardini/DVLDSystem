using ApplicationBusinessLayer14;
using LicenseClassesBusinessLayer;
using LicensesBusinessLayer;
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
    public partial class ApplicationNewLicenseInfo : UserControl
    {

        int LicenseID = 0;

        public ApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        public void StoreTheDataInControlWhenIhaveLicenseID(int LicenseID)
        {
            int ApplicationType = Licenses.GetLicenseClassByLicenseID(LicenseID);

            int Number1 = (int)LicenseClasses.GetTheClassFeesByLicenseClass(ApplicationType);
            int Number2 = (int)Application14.GetFeesApplicationByApplicationTypeID(2);

            int Number3 = Number1 + Number2;
            LbAllFees.Text=Number3.ToString();
            this.LicenseID = LicenseID;
            LbOldLicenseID.Text = LicenseID.ToString();
            int Year = DateTime.Now.Year + LicenseClasses.GetDefaultValidityLengthByLicenseID(LicenseID);
            MessageBox.Show(LicenseClasses.GetDefaultValidityLengthByLicenseID(LicenseID).ToString());

            LbLicenseFees.Text = LicenseClasses.GetTheClassFeesByLicenseClass(ApplicationType).ToString();
            LbExpirationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + Year.ToString();
        }
        public void StoreTheDataInControl()
        { 
            LbApplicationFees.Text = Application14.GetFeesApplicationByApplicationTypeID(2).ToString();
          
            LbUserID.Text = User.GetUserNameByUserID(User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));

            LbApplicationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
            LbIssueDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();


        }
        public void StoreTheApplicationID(int ApplicationID)
        {
            LbApplicationID.Text = ApplicationID.ToString();

        }

        public void StoreTheLicenseIDNew(int LicenseID)
        {
           LbLicenseIDNew.Text = LicenseID.ToString();  
        }
        public string Notes()
        {
            return TbNotes.Text;
        }
        

        private void ApplicationNewLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

