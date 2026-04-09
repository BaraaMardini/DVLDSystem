using ApplicationBusinessLayer14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestBusinessLayer;
using UserBusinessLayer;

namespace مشروع_كورس_19
{
    public partial class UpdateTestType : Form
    {

        int TestTypeID = 0;
        public UpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            this.TestTypeID = TestTypeID;

        }



        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StoreTheInfoInControl()
        {

            DataTable table = Test.GetOnlyTestTypeByID(TestTypeID);

            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                LbID.Text = row[0].ToString();
                TbTitle.Text = row[1].ToString();
               TbDescription.Text = row[2].ToString();
                TbFees.Text = row[3].ToString();


            }

        }
        private bool CheakOfTheControl()
        {
            if (TbFees.Text.Length == 0)
            {
                return false;
            }
            if (TbTitle.Text.Length == 0)
            {
                return false;
            }
            if(TbDescription.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void TbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            StoreTheInfoInControl();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {

            if (CheakOfTheControl()) { 
            Test.UpdateApplicationType(TestTypeID,TbFees.Text,TbDescription.Text,TbFees.Text);

                MessageBox.Show("العملية تمت بنجاح");

            }
            else
            {

                MessageBox.Show("العملية تمت بفشل");
            }
            
        }
    }
}
