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
using UserBusinessLayer;
namespace مشروع_كورس_19
{
    public partial class Manage_Application_Type : Form
    {
        public Manage_Application_Type()
        {
            InitializeComponent();
        }
        private void StoreTheDataInDataGridView()
        {
            dataGridView1.DataSource = Application14.GetAllApplicationType();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            LbNumberRecord.Text = dataGridView1.RowCount.ToString();
        }

        private void Manage_Application_Type_Load(object sender, EventArgs e)
        {
          StoreTheDataInDataGridView();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateApplicationType frm = new UpdateApplicationType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            StoreTheDataInDataGridView();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
