using PeopleBusinessLayer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UserBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace مشروع_كورس_19
{
    public partial class DetailsUser : UserControl
    {
        public DetailsUser()
        {
            InitializeComponent();
        }
        private int personID;

        [Browsable(true)]
        [Category("Data")]
        public int PersonID
        {
            get { return personID; }
            set
            {
                personID = value;
                if (personID > 0)
                   GetThePersonByPersonID();
            }
        }


        private void GetThePersonByPersonID()
        {

            DataTable dt = User.GetUserByPersonID1(PersonID);
            DataRow row = dt.Rows[0];
            string UserID = row[0].ToString();
            LbUserID.Text = UserID;
            LbUserName.Text = row[2].ToString();
            
          
            string IsActive = row[4].ToString();
            if (IsActive == "True")
            {
              LbIsActive.Text = "True";
            }
            else
            {
                LbIsActive.Text = "False";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DetailsUser_Load(object sender, EventArgs e)
        {

        }
    }
}




