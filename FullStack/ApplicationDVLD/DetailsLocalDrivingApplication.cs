using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_كورس_19
{
    public partial class DetailsLocalDrivingApplication : Form
    {
        int LocalDrivingLicenseApplicationID = 0;
        public DetailsLocalDrivingApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
         this.LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplicationID;
        }

        private void DetailsLocalDrivingApplication_Load(object sender, EventArgs e)
        {

            localDriveApplicationDetails1.LocalDriveApplicationID = LocalDrivingLicenseApplicationID;
            localDriveApplicationDetails1.UpdateDisplay();
        }

        
    }
}
