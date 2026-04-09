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
    public partial class DetainInfo : UserControl
    {
        public DetainInfo()
        {
            InitializeComponent();
        }

       public decimal GetFineFees()
        {

            if (textBox1.Text.Length >0)
            {

                return decimal.Parse(textBox1.Text);

            }

             else
            {
                MessageBox.Show("Fine fees  فارغ");
                return 0;
               
            }
        }

        public void StoreLicenseID(int LicenseID)
        {

            LbLicenseID.Text = LicenseID.ToString();    
        }
        public void StoreDetainID(int DetainID)

        {
            LbDetainID.Text = DetainID.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!(int.TryParse(textBox1.Text, out int number)))
            {

               textBox1.ReadOnly = false;
                textBox1.Clear();





            }
            else
            {
                textBox1.ReadOnly = false;

            }

        }

        private void DetainInfo_Load(object sender, EventArgs e)
        {
            LbUserID.Text = User.GetUserNameByUserID(User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));
            LbDetainDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.ToString("MMMM") + "/" + DateTime.Now.Year.ToString();
        }
    }
}
