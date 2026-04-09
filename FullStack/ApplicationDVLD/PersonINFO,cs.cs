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
    public partial class PersonINFO_cs : Form
    {

        int ID;
        public PersonINFO_cs(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        private void PersonINFO_cs_Load(object sender, EventArgs e)
        {

        
          personDetails1.PersonID = ID;
        }

        private void personDetails1_Load(object sender, EventArgs e)
        {

        }

    }
}
