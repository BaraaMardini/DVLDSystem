using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_كورس_19
{
    public partial class DetailsPersonUser : UserControl
    {




        private int personID;


        [Browsable(true)]
        [Category("Data")]
        public int PersonID
        {
            get { return personID; }
            set
            {
                personID = value;
      
            }
        }

     


        public DetailsPersonUser()
        {
            InitializeComponent();
        }

        private void personDetails1_Load(object sender, EventArgs e)
        {
            
        }

        private void DetailsPersonAndUserInfo_Load(object sender, EventArgs e)
        {
            personDetails1.PersonID = personID;
            detailsUser1.PersonID = personID;

        }
    }
}
