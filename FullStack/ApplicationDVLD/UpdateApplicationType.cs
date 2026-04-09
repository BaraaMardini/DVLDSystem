using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBusinessLayer14;
namespace مشروع_كورس_19
{
    public partial class UpdateApplicationType : Form
    {
        int ApplicationID = 0;
        public UpdateApplicationType(int ApplicationID)
        {
            InitializeComponent();
            this.ApplicationID = ApplicationID;
       
        }
        private void StoreTheInfoInControl()
        {

            DataTable table = Application14.GetOnlyApplicationTypeByID(ApplicationID);

            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                LbID.Text = row[0].ToString();
                TbTitle.Text = row[1].ToString();
                TbFees.Text = row[2].ToString();
        

            }

        }
        private bool CheakOfTheControl()
        {
            if (TbFees.Text.Length == 0)
            {
                return false;
            }
            if(TbTitle.Text.Length == 0) { 
                return false;
            }

            return true;
        }


        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            StoreTheInfoInControl();
            

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (CheakOfTheControl())
            {
                Application14.UpdateApplicationType(ApplicationID,TbTitle.Text,TbFees.Text);
                MessageBox.Show("العميلة تمت بنجاح");


            }
            else
            {
                MessageBox.Show("العميلة تمت بفشل");

            }


        }

        private void TbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }