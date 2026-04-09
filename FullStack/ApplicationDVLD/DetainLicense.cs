using DetainedLicensesBusinessLayer;
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
    public partial class DetainLicense : Form
    {
        int LicenseID = 0;
        public DetainLicense()
        {
            InitializeComponent();

        }


        private void filterLicense1_Load(object sender, EventArgs e)
        {
            filterLicense1.NumberUntilChoeseBetweenScreen = 3;
            filterLicense1.DataBack6 += HandleData;
            filterLicense1.DataBack7 += HandleData2;

        }

        private void HandleData(object sender, int LicenseID)
        {
            this.LicenseID = LicenseID;
            BtDetain.Enabled = false;
            ShowLicenseHistory.Enabled = true;


            detainInfo1.StoreLicenseID(LicenseID);





        }

        private void HandleData2(object sender, int LicenseID)
        {
            this.LicenseID = LicenseID;
            BtDetain.Enabled = true;
            ShowLicenseHistory.Enabled = true;

            

            detainInfo1.StoreLicenseID(LicenseID);





        }
        private bool AddNewDetain()
        {
            

            DialogResult result = MessageBox.Show(
    "Are you sure you want to detain this license?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int DetainID = DetainedLicenses.AddNewDetainedLicense(this.LicenseID, DateTime.Now, detainInfo1.GetFineFees(),
               User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), 0);

                MessageBox.Show(detainInfo1.GetFineFees().ToString());

                detainInfo1.StoreDetainID(DetainID);


                
                MessageBox.Show(
                    $"License Detained Successfully with ID={DetainID}",
                    "License Issued",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
        
            }
            else
            {
                return false;
            }





        }




        private void BtDetain_Click(object sender, EventArgs e)
        {
            int Fees = (int)detainInfo1.GetFineFees();
            if (Fees !=0)
            {
             if(AddNewDetain())
                {
                    
                    filterLicense1.EnabledFilter();
                    BtDetain.Enabled = false;

                    ShowNewLicenseInfo.Enabled = true;

                }
            

             

            }
            else
            {

            }
        }

        private void ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LicenseInfo frm = new LicenseInfo(0, LicenseID);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void DetainLicense_Load(object sender, EventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}