using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleBusinessLayer1;
using UserBusinessLayer;
using ApplicationBusinessLayer14;
using LicensesBusinessLayer;
namespace مشروع_كورس_19
{
    public partial class Form1 : Form
    {
        public Form1(string UserName, string Password)
        {



            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            UserInfo.UserName = UserName;
            UserInfo.Password = Password;
       


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {


            PeopleManage frm = new PeopleManage();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(); 


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ManageUsers frm = new ManageUsers ();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void cureentToolStripMenuItem_Click(object sender, EventArgs e)
        {

           DetailsUserAndPersonInfo frm = new DetailsUserAndPersonInfo(User.GetPersonIdByUserNameAndPassword(UserInfo.UserName,UserInfo.Password));
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ChangePassword frm = new ChangePassword(User.GetPersonIdByUserNameAndPassword(UserInfo.UserName, UserInfo.Password));
            // احصل على أبعاد الشاشة
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            // اضبط ارتفاع الفورم ليملأ الشاشة عموديًا
            frm.Height = screenHeight;

            // الموقع الأفقي: المنتصف
            int x = (screenWidth - frm.Width) / 2;

            // الموقع العمودي: أعلى الشاشة (Y = 0)
            int y = 0;

            // اضبط الموقع يدويًا
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(x, y);

            // اعرض الفورم
            frm.ShowDialog();





  

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            this.Close();
            
            
        }

        private void manageAplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Application_Type frm = new Manage_Application_Type();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();


        }

        private void manageTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTestTypes frm = new ListTestTypes();
            frm.StartPosition = FormStartPosition.CenterParent;
          //  frm.Size = new Size(1400, 800); // تعديل الطول فقط
            frm.ShowDialog();


        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplication frm = new NewLocalDrivingLicenseApplication();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplication frm = new LocalDrivingLicenseApplication();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void newDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListDrivers frm = new ListDrivers();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void gToolStripMenuItem2_Click(object sender, EventArgs e)
        {


        }

        private void interToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ListInternationalLicesneApplication
            ListInternationalLicesneApplication frm = new ListInternationalLicesneApplication();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();



        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication frm = new NewInternationalLicenseApplication();

            // إعداد يدوي للموقع
            frm.StartPosition = FormStartPosition.Manual;

            // تعيين العرض الجديد (مثلاً 800 بدلاً من 400)
            frm.Width = 900;

            // جعل الارتفاع يغطي الشاشة بالكامل
            frm.Height = Screen.PrimaryScreen.Bounds.Height;

            // حساب X ليكون في منتصف الشاشة حسب العرض الجديد
            int x = (Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2;
            int y = 0;

            // تعيين الموقع
            frm.Location = new Point(x, y);

            // (اختياري) إزالة الحدود
            // frm.FormBorderStyle = FormBorderStyle.None;

            // عرض الفورم
            frm.ShowDialog();

        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
          RenewLocalDrivingLicense frm = new RenewLocalDrivingLicense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(820, 850); // تعديل الطول فقط
            frm.ShowDialog();
        }

        private void replecementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForDamagedLicense frm = new ReplacementForDamagedLicense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DetainLicense frm = new DetainLicense();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();





        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ReleaseDetainedLicense frm = new ReleaseDetainedLicense(0);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();


        }

        private void manageDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDetainedLicenses frm = new ListDetainedLicenses();
            frm.StartPosition = FormStartPosition.CenterParent;
            //frm.Size = new Size(890, 790); // تعديل الطول فقط
            frm.ShowDialog();
        }
    }
}



