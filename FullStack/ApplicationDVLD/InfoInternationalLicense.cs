using InternationalLicensesBusinessLayer;
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
    public partial class InfoInternationalLicense : UserControl
    {
        public InfoInternationalLicense()
        {
            InitializeComponent();
        }
        int InternationalLicenseID = 0;

        public void GetInternationalID(int InternationalLicenseID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
        }


        public void StoreTheDataInControl()
        {

            MessageBox.Show(this.InternationalLicenseID.ToString());
            DataTable table = InternationalLicenses.GetInterNationalLicenseByILID(this.InternationalLicenseID);


            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                LbName.Text=row[0].ToString();
              
                LbInternationalLicesneID.Text = row[1].ToString();
            
                LbLicenseID.Text = row[2].ToString();
               LbNationalNO.Text = row[3].ToString();
                LbGendor.Text = row[4].ToString();
            
                DateTime IssueDate = Convert.ToDateTime(row[5]);
                LbIssueDate.Text=IssueDate.Day.ToString()+"/" + IssueDate.ToString("MMMM")+"/" +IssueDate.Year.ToString();
                //+ DateTime.Now.ToString("MMMM")
                LbApplicationID.Text = row[6].ToString();
                LbIsActive.Text = row[7].ToString();
             
                DateTime DateOfBirth = Convert.ToDateTime(row[8]);
                LbDateOfBirth.Text=DateOfBirth.Day.ToString()+"/"+ DateOfBirth.ToString("MMMM")+"/"+DateOfBirth.Year.ToString();
                LbDriveID.Text = row[9].ToString();
           
                DateTime ExpirationDate= Convert.ToDateTime(row[10]);
                LbExpirationDate.Text=ExpirationDate.Day.ToString()+"/"+ExpirationDate.ToString("MMMM")+"/"+ExpirationDate.Year.ToString();



            }
            else
            {


            }




        }

        private void InfoInternationalLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
