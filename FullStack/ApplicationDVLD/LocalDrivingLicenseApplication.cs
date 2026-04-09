using ApplicationBusinessLayer14;
using LicensesBusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace مشروع_كورس_19
{
    public partial class LocalDrivingLicenseApplication : Form
    {
        public LocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
             
        private void RefreshContextMenuOptions()
        {
            if ((int)dataGridView1.CurrentRow.Cells[5].Value == 0)
            {
                sechduleTestToolStripMenuItem.Enabled = true;
                scheduleVisionTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = true;


            }
            if ((int)dataGridView1.CurrentRow.Cells[5].Value == 1)
            {
                sechduleTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = true;

            }

            if ((int)dataGridView1.CurrentRow.Cells[5].Value == 2)
            {
                sechduleTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = true;
            }
            if ((int)dataGridView1.CurrentRow.Cells[5].Value == 3)
            {
                sechduleTestToolStripMenuItem.Enabled = true;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;

            }

            if ((string)dataGridView1.CurrentRow.Cells[6].Value == "Completed")
            {
                sechduleTestToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;

            }

            if ((string)dataGridView1.CurrentRow.Cells[6].Value == "Cancelled")
            {
                sechduleTestToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;


            }

            if ((int)dataGridView1.CurrentRow.Cells[5].Value == 3  && (string)dataGridView1.CurrentRow.Cells[6].Value == "New")
            {
                sechduleTestToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                deleteApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                issueDrivingLicenceFirstTimeToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;


            }


        }


        private void FilterLocalDrivingApplicationByAppID()
        {
           LoadAllLocalDrivingApplicationData();
            DataTable EmployeesDataTable =  LocalDrivingApplication.GetAllLocalDrivingApplicationData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][0].ToString() == TbFilter.Text.ToString())
                {
                   
                    string c =  EmployeesDataTable.Rows[i][0].ToString();

                    ResultRows = EmployeesDataTable.Select("[L.D.L.AppID] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }

        private void FilterLocalDrivingApplicationByNationalNO()
        {
            LoadAllLocalDrivingApplicationData();
            DataTable EmployeesDataTable = LocalDrivingApplication.GetAllLocalDrivingApplicationData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][2].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][2].ToString();

                    ResultRows = EmployeesDataTable.Select("[National NO] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }

        private void FilterLocalDrivingApplicationByFullName()
        {
            LoadAllLocalDrivingApplicationData();
            DataTable EmployeesDataTable = LocalDrivingApplication.GetAllLocalDrivingApplicationData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][3].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][3].ToString();

                    ResultRows = EmployeesDataTable.Select("[Full Name] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }

        private void FilterLocalDrivingApplicationByStatus()
        {
            LoadAllLocalDrivingApplicationData();
            DataTable EmployeesDataTable = LocalDrivingApplication.GetAllLocalDrivingApplicationData();
            int ResultCount = 0;
            DataRow[] ResultRows;


            for (int i = 0; i < EmployeesDataTable.Rows.Count; i++)
            {

                //   if3   0  
                if (EmployeesDataTable.Rows[i][6].ToString() == TbFilter.Text.ToString())
                {

                    string c = EmployeesDataTable.Rows[i][6].ToString();

                    ResultRows = EmployeesDataTable.Select("[Status] = '" + c + "'");
                    if (ResultRows.Length > 0)
                    {
                        dataGridView1.DataSource = ResultRows.CopyToDataTable();
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // أو DataTable فاضية
                    }



                }



            }

        }






        private void LoadAllLocalDrivingApplicationData()
        {
            dataGridView1.DataSource =LocalDrivingApplication.GetAllLocalDrivingApplicationData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            LbNumberRow.Text=dataGridView1.RowCount.ToString();

        }


        private bool HandleTextFilterSelection()
        {

            if (CbFilter.Text == "L.D.L.AppID")
            {
                SetFilterTextBoxForNumericInput();
                FilterLocalDrivingApplicationByAppID();
                return true;

            }
            if (CbFilter.Text == "National NO")
            {
                SetFilterTextBoxForStringInput();
                FilterLocalDrivingApplicationByNationalNO();
                
                return true;

            }
            if (CbFilter.Text == "Status")
            {
                SetFilterTextBoxForStringInput();
                FilterLocalDrivingApplicationByStatus();
                return true;

            }
            if (CbFilter.Text == "Full Name")
            {
                SetFilterTextBoxForStringInput();
                FilterLocalDrivingApplicationByFullName();
                return true;

            }
            if (CbFilter.Text == "None")
            {
                TbFilter.Visible = false;
                return true;

            }
            return true;


        }

        private void SetFilterTextBoxForStringInput()
        {
            if (int.TryParse(TbFilter.Text, out int number))
            {

                TbFilter.ReadOnly = true;
                TbFilter.Clear();



            }
            else
            {

                TbFilter.ReadOnly = false;

            }


        }
        private void SetFilterTextBoxForNumericInput()
        {

            if (!(int.TryParse(TbFilter.Text, out int number)))
            {

                TbFilter.ReadOnly = false;
                TbFilter.Clear();





            }
            else
            {
                TbFilter.ReadOnly = false;

            }



        }
        private bool UpdateFilterInputVisibility()
        {
            if (CbFilter.Text== "L.D.L.AppID")
            {
                TbFilter.Visible = true;
                return true;

            }
            if (CbFilter.Text == "National NO")
            {
                TbFilter.Visible = true;
                return true;

            }
            if (CbFilter.Text == "Status")
            {
                TbFilter.Visible = true;
                return true;

            }
            if (CbFilter.Text=="Full Name")
            {
                TbFilter.Visible = true;
                return true;

            }
            if (CbFilter.Text == "None")
            {
                TbFilter.Visible = false;
                return true;

            }
            return true;
        }

        private void LocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            LoadAllLocalDrivingApplicationData();
       

        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilterInputVisibility();  
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            HandleTextFilterSelection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplication frm = new NewLocalDrivingLicenseApplication();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            LoadAllLocalDrivingApplicationData();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDriveApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int ApplicationID=LocalDrivingApplication.GetApplicationIDByLocalDriveApplicationID(LocalDriveApplicationID);
            Application14.UpdateStatusAndLastStatusDate(ApplicationID,2,DateTime.Now);
            LoadAllLocalDrivingApplicationData();

           
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsLocalDrivingApplication frm = new DetailsLocalDrivingApplication((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

      

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            RefreshContextMenuOptions();
          

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {//5

            //(int)dataGridView1.CurrentRow.Cells[5].Value

            VisionTestAppointments frm = new VisionTestAppointments((int)dataGridView1.CurrentRow.Cells[0].Value, 1, (string)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;
          
            frm.ShowDialog();
            LoadAllLocalDrivingApplicationData();
            

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionTestAppointments frm = new VisionTestAppointments((int)dataGridView1.CurrentRow.Cells[0].Value, 2, (string)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog(); 
            LoadAllLocalDrivingApplicationData();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VisionTestAppointments frm = new VisionTestAppointments((int)dataGridView1.CurrentRow.Cells[0].Value, 3, (string)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
            LoadAllLocalDrivingApplicationData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void issueDrivingLicenceFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

           IssueDriverLicense frm = new IssueDriverLicense((int)dataGridView1.CurrentRow.Cells[0].Value, (string)dataGridView1.CurrentRow.Cells[1].Value);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
            LoadAllLocalDrivingApplicationData();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            LicenseInfo frm = new LicenseInfo((int)dataGridView1.CurrentRow.Cells[0].Value,0);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();
        }

        private void showPersonLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LicenseHistory
            LicenseHistory frm = new LicenseHistory((int)dataGridView1.CurrentRow.Cells[0].Value,0);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();



        }
    }
}
