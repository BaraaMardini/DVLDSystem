using ApplicationBusinessLayer14;
using DetainedLicensesBusinessLayer;
using DriverBusinessLayer;
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
using System.Xml.Linq;
using UserBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class DetainInfo2 : UserControl
    {

        public int LicenseID = 0;
        public DetainInfo2()
        {
            InitializeComponent();
        }
        public void StoreDataInControl()
        {
            MessageBox.Show(LicenseID.ToString());


            DataTable table = DetainedLicenses.GetDetainedLicenseByLicenseID(LicenseID);
            //  LbApplicationDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
            int FineFees = 0;
            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                DateTime dateTime = Convert.ToDateTime(row[2]);

                LbDetainID.Text = row[0].ToString();
                LbLicenseID.Text = row[1].ToString();
                LbDetainDate.Text = dateTime.Day.ToString() + "/" + dateTime.Month.ToString("MMMM") + "/" + dateTime.Year.ToString();
                LbFineFees.Text = row[3].ToString();
                FineFees = Convert.ToInt32(row[3]);




            }
            LbApplicationFees.Text = Application14.GetFeesApplicationByApplicationTypeID(5).ToString();
            int FeesApplication = (int)Application14.GetFeesApplicationByApplicationTypeID(5);
          //  int FineFees = Convert.ToInt32(LbFineFees.Text);
            int TotalFees = FeesApplication + FineFees;
            LbTotalFees.Text = TotalFees.ToString();
            LbUserID.Text = User.GetUserNameByUserID(User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));


        }




        public void StoreTheApplicationID(int ApplicationID)
        {


            LbApplicationID.Text = ApplicationID.ToString();
        }
        public void StoreLicenseID(int LicenseID) { 
        LbLicenseID.Text= LicenseID.ToString(); 
        
        }

        public int GetDetainID()
        {
            return  Convert.ToInt32( LbDetainID.Text);
        }

        private void DetainInfo2_Load(object sender, EventArgs e)
        {

        }
    }
}
