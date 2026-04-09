using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace مشروع_كورس_19
{
    public partial class LicenseInfo : Form
    {
        int LocalDriveApplicationID = 0;
        int LicenseID = 0;
        public LicenseInfo(int LocalDriveApplicationID,int LicenseID)
        {
            InitializeComponent();
            this.LocalDriveApplicationID = LocalDriveApplicationID;
            this.LicenseID = LicenseID; 
        }

        private void driverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            if (LocalDriveApplicationID != 0)
            {

                driverLicenseInfo1.LocalDriveApplicationID = LocalDriveApplicationID;
                driverLicenseInfo1.StoreTheDataInControls();
            }
            else
            {
                driverLicenseInfo1.LicenseID=this.LicenseID;
                driverLicenseInfo1.StoreTheDataInControls1();
            }




            }

            private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void driverLicenseInfo1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
