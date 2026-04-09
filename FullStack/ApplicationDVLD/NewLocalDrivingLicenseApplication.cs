using ApplicationBusinessLayer14;
using DVLDBusinessLayer;
using LicenseClassesBusinessLayer;
using LocalDrivingApplicationBusinessLayer;
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
    public partial class NewLocalDrivingLicenseApplication : Form
    {
        public NewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

          private void AddNewLocalDrivingApplication()
        {
           
            int ApplicationID = Application14.AddNewApplication(filter1.ID, DateTime.Now, 1, 1, DateTime.Now, User.GetUserIDByUserNameAndPassword(UserInfo.UserName, UserInfo.Password), Application14.GetFeesApplicationByApplicationTypeID(1));

            int LocalDrivingApplicationID = LocalDrivingApplication.AddNewLocalDrivingApplication(ApplicationID, CbLicenseClass.SelectedIndex + 1);
            LBLocalDriveApplicationID.Text =LocalDrivingApplicationID.ToString();




        }
        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheakIfTheApplicationSave()
        {
            if (filter1.ID == User.GetPersonIdByUserNameAndPassword(UserInfo.UserName, UserInfo.Password))
            {
                return false;
            }
            if (DVLD.ValidateNewLocalApplication(CbLicenseClass.Text, filter1.ID)) {

                return false;
            }

           


            return true;
        }
        private bool CheakIfFilterIDIsNull()
        {
            if (filter1.ID == 0)
            {


                return false;
            }
            return true;

        }
        private void GiveNameToControl()
        {
            CbLicenseClass.DataSource = LicenseClasses.GetAllClassName();
            CbLicenseClass.DisplayMember = "ClassName";       // الاسم الذي يظهر للمستخدم
            LbApplicationDate.Text = DateTime.Now.ToString();
            LbCreated.Text = UserInfo.UserName;

        }

        private void NewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
           GiveNameToControl();
            CbLicenseClass.Text = "Class 1 - Small Motorcycle";


        }
       private  bool SaveTheApplication()
        {

            if (filter1.ID == User.GetPersonIdByUserNameAndPassword(UserInfo.UserName, UserInfo.Password))
            {
                MessageBox.Show(" لا يمكن حفظ هذا الشخص لان الشخص نفسو مستخدم في السستم");
                return false;
            }

            if (!CheakIfFilterIDIsNull())
            {
                MessageBox.Show(" لا يوجد رقم الشخص ");
                return false;
            }

            if (CheakIfTheApplicationSave() )
            {


                AddNewLocalDrivingApplication();
                MessageBox.Show("لقد تمت العملية بنجاح");

            }
            else
            {
                MessageBox.Show("Choose another license class , the selected Person Already have an active application for the selected class with id=" + filter1.ID);

            }
            return true;

        }
        private void BtSave_Click(object sender, EventArgs e)
        {

           SaveTheApplication();
        }

        private void LbApplicationDate_Click(object sender, EventArgs e)
        {

        }
    }
}
