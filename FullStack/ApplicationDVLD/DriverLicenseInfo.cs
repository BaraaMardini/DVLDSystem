using DetainedLicensesBusinessLayer;
using DriverBusinessLayer;
using LicensesBusinessLayer;
using PeopleBusinessLayer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_كورس_19
{
    public partial class DriverLicenseInfo : UserControl
    {
        public DriverLicenseInfo()
        {
            InitializeComponent();
        }
      public  int LocalDriveApplicationID = 0;

        public int LicenseID = 0;

        public void StoreTheDataInControls()
        {
            int LicenseID = Licenses.GetLicenseIDByLocalDrivingLicenseApplications(LocalDriveApplicationID);

            MessageBox.Show(LicenseID.ToString());


            DataTable table = Driver.GetDataDriver(LicenseID);


            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                LbClassName.Text = row[0].ToString();
                LbName.Text = row[1].ToString();
                LbLicenseID.Text = row[2].ToString();
                LbNationalNO.Text = row[3].ToString();
                LbGendor.Text = row[4].ToString();
                LbIssueDate.Text = row[5].ToString();
                LbIssueReason.Text = row[6].ToString();
                LbNotes.Text = row[7].ToString();
                LbIsActive.Text = row[8].ToString();
                LbDateOfBirth.Text = row[9].ToString();
                LbDriveID.Text = row[10].ToString();
                LbExpirationDate.Text = row[11].ToString();
                if (DetainedLicenses.CheakLicenseIDIsReleased(LicenseID, 0))
                {

                    LbIsDetained.Text = "Yes";

                }
                else
                {


                    LbIsDetained.Text = row[12].ToString();
                }



                if (LbGendor.Text == "Female")
                {
                    PbBigMale.BackgroundImage = PbFemale.BackgroundImage;
                    PbBigMale.BackgroundImage = PbBigFemale.BackgroundImage;
                }
                if (LbNotes.Text.Length == 0)
                {
                    LbNotes.Text = "No Notes";
                }



            }
            else
            {


            }
        }
      
            public void StoreTheDataInControls1()
            {
               

                DataTable table = Driver.GetDataDriver(LicenseID);


                if (table != null && table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    LbClassName.Text = row[0].ToString();
                    LbName.Text = row[1].ToString();
                    LbLicenseID.Text = row[2].ToString();
                    LbNationalNO.Text = row[3].ToString();
                    LbGendor.Text = row[4].ToString();
                    LbIssueDate.Text = row[5].ToString();
                    LbIssueReason.Text = row[6].ToString();
                    LbNotes.Text = row[7].ToString();
                    LbIsActive.Text = row[8].ToString();
                    LbDateOfBirth.Text = row[9].ToString();
                    LbDriveID.Text = row[10].ToString();
                    LbExpirationDate.Text = row[11].ToString();
                if (DetainedLicenses.CheakLicenseIDIsReleased(LicenseID, 0))
                {

                    LbIsDetained.Text = "Yes";

                }
                else
                {


                    LbIsDetained.Text = row[12].ToString();
                }





                    if (LbGendor.Text == "Female")
                    {
                        PbBigMale.BackgroundImage = PbFemale.BackgroundImage;
                        PbBigMale.BackgroundImage = PbBigFemale.BackgroundImage;
                    }
                    if (LbNotes.Text.Length == 0)
                    {
                        LbNotes.Text = "No Notes";
                    }



                }
                else
                {


                }



            }
        public  string IsActive()
        {
            return LbIsActive.Text;

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DriverLicenseInfo_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        }
    }

