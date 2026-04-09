using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using مشروع_كورس_19;
using UserBusinessLayer;
namespace LoginAccount
{
    public partial class LoginAccount : Form
    {
        public LoginAccount()
        {
            InitializeComponent();
        }




        private bool CheakTheInfo()
        {
            if (User.FindTheUserName(TbUserName.Text)) {
          
            }
            else
            {
                MessageBox.Show(" لا يوحد هذا الاسم");
                return false;
            }


            if(User.FindTheUserNameAndPassword(TbUserName.Text,TbPassword.Text))
            {

              
            }

            else
            {
                MessageBox.Show("كلمة السر غير صحيحة");
                return false;
            }
            if (User.FindTheUserNameAndPasswordAndActive(TbUserName.Text, TbPassword.Text, 1))
            {
               
            }
            else
            {
                MessageBox.Show("هذا غير فعال");
                return false;
            }


            return true;
        
        }


        private void JoinToForm1()
        {
            Form1 frm = new Form1(TbUserName.Text, TbPassword.Text);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            

        }
        private void LoginAccount_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (CheakTheInfo())
            //  {
            //      JoinToForm1();
            //  }
            TbUserName.Text = "Msaqer77";
            TbPassword.Text = "1234";
            JoinToForm1();


          

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
