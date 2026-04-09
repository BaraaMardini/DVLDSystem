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
using UserBusinessLayer;
using مشروع_كورس_19;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class AddNewUser : Form
    {
        int ID = 0;
        int PersonID = 0;

        private void FillUserControls()
        {

            DataTable dt = User.GetUserByPersonID1(ID);
            DataRow row = dt.Rows[0];
            string UserID = row[0].ToString();
            LbUserID.Text = UserID;
            TbUserName.Text=row[2].ToString();
            TbPassword.Text = row[3].ToString();
            TbConfirmPassword.Text = row[3].ToString();
            string IsActive=row[4].ToString();
            MessageBox.Show(IsActive);
            if (IsActive=="True")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

        }

        private bool ValidateUserInputs()
        {
            if (string.IsNullOrWhiteSpace(TbUserName.Text))
            {
                errorProvider1.SetError(TbUserName, "الرجاء عدم ترك الحقل فارغاً");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                errorProvider1.SetError(TbPassword, "الرجاء عدم ترك الحقل فارغاً");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TbConfirmPassword.Text))
            {
                errorProvider1.SetError(TbConfirmPassword, "الرجاء عدم ترك الحقل فارغاً");
                return false;
            }
            if (TbPassword.Text != TbConfirmPassword.Text)
            {
                errorProvider1.SetError(TbConfirmPassword, " تأكيد كلمة المرور يوجد بها خطأ");
                return false;

            }





            return true;
        }

        private bool SaveUserData()
        {

              SetPersonIDFromFilter();
            int b;
            int UserID;
            if (checkBox1.Checked == true)
            {
                b = 1;

            }
            else
            {
                b = 0;
            }
            if (ID != -1)
            {
                if (ValidateUserInputs())
                {


                    User.UpdateUserInfo(PersonID, TbUserName.Text, TbPassword.Text, b);

                    MessageBox.Show("العملية تمت بنجاح ");
                 
                    return true;



                }


            }
            else
            {

                if (User.FindThePersonID(PersonID))
                {
                    MessageBox.Show(" لا يمكنك اضافة هذا الشخص لانو موجود من قبل ");
                    return false;

                }

                if (ValidateUserInputs())
                {
                   
                UserID   =User.AddNewUser(PersonID, TbUserName.Text,TbPassword.Text,b);
                    LbUserID.Text=UserID.ToString();
                    MessageBox.Show("العملية تمت بنجاح ");
                    return true;
                }


            }

            MessageBox.Show( " العميلة تمت بفشل ");
            return   true;

        }

        private void SetPersonIDFromFilter()
        {
            PersonID = filter1.ID;
            MessageBox.Show(PersonID.ToString());

         

        }
        private bool IsUserAlreadyLinkedToAccount()
        {
            SetPersonIDFromFilter(); 

            if (User.FindThePersonID(PersonID))
            {
                return false;
            }


            return true;
        }

        private bool TryOpenUserTab()
        {
            if (ID != -1)
            {

                tabControl1.SelectedIndex = 1;
                return true;
            }



            SetPersonIDFromFilter();
            if (PersonID == 0)
            {
                MessageBox.Show("  معلومات الشخص فاضية");

            }


       else      if (!IsUserAlreadyLinkedToAccount())
            {
                MessageBox.Show("لا يمكنك الدخول لان هذا الشخص لديه USER ");
            }
            else
            {

                tabControl1.SelectedIndex = 1;

            }

            return true;    
        }
        private void StorePersonIDFromFilter()
        {
            PersonID = filter1.ID;

          

        }

        private bool LoadDataIfEditMode()
        {
            if (ID != -1)
            {
                filter1.ReceiveMessage(ID);
                FillUserControls();
            }

            return true;

        }
        private void SetFormTitleAndHeader()
        {
            if (ID != -1)
            {
                this.Text = "Update User";
                LbNaming.Text = "Update User";
            }
            else
            {
                LbNaming.Text = "Add New User";
            }
        }

        public AddNewUser(int ID)
        {
            InitializeComponent();
            this.ID = ID;

        }


        private void AddNewUser_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ID.ToString());

            LoadDataIfEditMode();

            StorePersonIDFromFilter();
            SetFormTitleAndHeader();



            filter1.AutoScroll = false;

        }

       

      

        private void BtNext_Click(object sender, EventArgs e)
        {
            TryOpenUserTab();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {



            SaveUserData();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filter1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void filter1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
          
        }
    }
}
