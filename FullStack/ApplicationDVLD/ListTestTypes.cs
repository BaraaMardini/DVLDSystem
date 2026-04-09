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
namespace مشروع_كورس_19
{
    public partial class ListTestTypes : Form
    {
        public ListTestTypes()
        {
            InitializeComponent();
        }

        private void StoreTheDataInDataGridView()
        {
            dataGridView1.DataSource = Test.GetAllTestType();
            LbNumberRecord.Text=dataGridView1.RowCount.ToString();
        }

      
        private void ListTestTypes_Load_1(object sender, EventArgs e)
        {
            StoreTheDataInDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTestType frm=new UpdateTestType((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            StoreTheDataInDataGridView();

        }
    }
}
