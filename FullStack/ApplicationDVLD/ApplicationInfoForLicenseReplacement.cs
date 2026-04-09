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
    public partial class ApplicationInfoForLicenseReplacement : UserControl
    {
        public ApplicationInfoForLicenseReplacement()
        {
            InitializeComponent();
        }

        private void ApplicationInfoForLicenseReplacement_Load(object sender, EventArgs e)
        {

        }
        public void StoreValueOfApplicationFees(int Fees)
        {
          LbApplicationFees.Text = Fees.ToString();
           

        }
        public void StoreDataInControl()
        {
            LbApplicationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
            LbUserID.Text = User.GetUserNameByUserID(User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));
    
        }
        public void StoreOldLicenseID(int LicesneID)
        {
            LbOldLicenseID.Text = LicesneID.ToString();
        }
        public void StoreNewLicenseID(int LicenseID)
        {
            LbLicenseIDNew.Text = LicenseID.ToString(); 

        }
        public void StoreApplicationID(int ApplicationID)
        {
            LbApplicationID.Text = ApplicationID.ToString();

        }




    }
}
