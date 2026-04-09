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
    public partial class ChangePassword : Form
    {
        string Password;
        int PersonID;
        public ChangePassword(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
            detailsPersonUser1.PersonID = PersonID;
        }

        private void LoadCurrentPassword()
        {
            DataTable dt = User.GetUserByPersonID1(PersonID);
            DataRow row = dt.Rows[0];
           Password = row[3].ToString();

        }



        private void ChangePassword_Load(object sender, EventArgs e)
        {
            LoadCurrentPassword();

        }

        private bool ValidateAndChangePassword()
        {
            if(TbCurrentPassword.Text!=Password)
            {
                errorProvider1.SetError(TbCurrentPassword, "هذه كلمة السر غلط");
                return false;
                     //errorProvider1.SetError(TbNationalNo, "يجب تغير الرقم الوطني لانه موجود في السستم");
            }
            else
            {
               
            }
            if (TbConfirmPassword.Text != TbNewPassword.Text)
            {
                errorProvider1.SetError(TbConfirmPassword , "لديك غلط في تأكيد كلمة المرور");
                return false;
            }

            User.ChangePassword(PersonID, TbNewPassword.Text);

            MessageBox.Show("العملية تمت بنجاح");
            return true;
        }









        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            ValidateAndChangePassword();

        }

        private void TbCurrentPassword_TextChanged(object sender, EventArgs e)
        {

            errorProvider1.SetError(TbCurrentPassword, "");
        }

        private void TbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(TbConfirmPassword, "");
        }

        private void detailsPersonUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
