using DVLDBusinessLayer;
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
    public partial class LocalDriveApplicationDetails : UserControl
    {



        public int LocalDriveApplicationID;
        int PersonID;

       



        public void UpdateDisplay()
        {
            int PassedTest = DVLD.GetPassedTestCountByLocalDrivingLicenseApplicationID(LocalDriveApplicationID);
            DataTable dt = DVLD.GetAllLocalDrivingLicenseApplications(LocalDriveApplicationID);
            LbPassedTest.Text = PassedTest.ToString() + "/3";



            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // أول صف
                int UserID = Convert.ToInt32(row[3]);
                PersonID= Convert.ToInt32(row[9]);
                // مثال تعبئة بعض عناصر التحكم (Labels)
                LbLocalDriveApplicationID.Text = row[0].ToString();
                LbApplicationID.Text = row[1].ToString();
                LbClassName.Text = row[4].ToString();
                LbDate.Text = row[5].ToString();
                LbStatusDate.Text = row[6].ToString();
                LbStatus.Text = row[7].ToString();
                LbFullName.Text = row[8].ToString();

                LbCreated.Text = User.GetUserNameByUserID(UserID);
            }
            else
            {
                MessageBox.Show("لا توجد بيانات للطلب المطلوب.");




            }
        }
            public LocalDriveApplicationDetails()
        {
            InitializeComponent();
        }
       
      

        private void LocalDriveApplicationDetails_Load(object sender, EventArgs e)
        {
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonINFO_cs frm = new PersonINFO_cs(PersonID);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void LocalDriveApplicationDetails_Load_1(object sender, EventArgs e)
        {

        }

        private void LbFees_Click(object sender, EventArgs e)
        {

        }
    }
}
