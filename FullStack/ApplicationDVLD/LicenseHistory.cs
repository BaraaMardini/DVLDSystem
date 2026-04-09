using DriverBusinessLayer;
using InternationalLicensesBusinessLayer;
using LicensesBusinessLayer;
using LocalDrivingApplicationBusinessLayer;
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

namespace مشروع_كورس_19
{
    public partial class LicenseHistory : Form
    {
        int LocalDriveApplicationID = 0;
        int PersonID = 0;
        int LicenseID = 0;
        public LicenseHistory(int LocalDriveApplicationID,int LicenseID)
        {
            InitializeComponent();
            this.LocalDriveApplicationID = LocalDriveApplicationID;
            this.LicenseID = LicenseID;

        
        }



        private void LoadLicenseData()
        {
            int DriverID = Driver.GetDriverIDByPersonID(PersonID);

            dataGridView1.DataSource = Licenses.GetInfoLicense(DriverID);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dataGridView2.DataSource = InternationalLicenses.GetInterNationalLicenseByIssuedUsingLocalLicenseID(LicenseID);

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                        
        }



        private void LicenseHistory_Load(object sender, EventArgs e)
        {
          


            if (LocalDriveApplicationID != 0)
            {
                int PersonID = LocalDrivingApplication.GetPersonIDByLocalDrivingApplicationID(this.LocalDriveApplicationID);
                personDetails1.PersonID = PersonID;
        
                this.PersonID = PersonID;
                LoadLicenseData();
            }
            if (LicenseID != 0) {

                int PersonID =People.GetPersonIDByLicenseID(LicenseID);
                MessageBox.Show(PersonID.ToString());
                personDetails1.PersonID = PersonID;

                this.PersonID = PersonID;
                LoadLicenseData();

            }


        
        }

        private void filter1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void filter1_Load_1(object sender, EventArgs e)
        {

        }

        private void personDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
