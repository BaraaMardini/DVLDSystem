using ApplicationBusinessLayer14;
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
    public partial class ApplicationInfo : UserControl
    {
        public ApplicationInfo()
        {
            InitializeComponent();
        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {

          

        }
        public void StoreTheLicenseID(int LicenseID)
        {
          LbLicenseID.Text = LicenseID.ToString();

        }




        public void StoreTheDataInControl()
        {
            LbApplicationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
            LbIssueDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
            LbExpirationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.AddYears(1).Year.   ToString();
            LbUserID.Text = UserInfo.UserName;
            LbFees.Text= Application14.GetFeesApplicationByApplicationTypeID(6).ToString();
        }

        public void StoreTheDataAfterConstructionInternationalLicense(int ApplicationID, int InternationalLicenseID)
        {
            LbApplicationID.Text = ApplicationID.ToString();
            LbInternationalLicesneID.Text = InternationalLicenseID.ToString();
            

        }




    }
}
