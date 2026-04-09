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
    public partial class DetailsUserAndPersonInfo : Form
    {
        int PersonID;
      
        public DetailsUserAndPersonInfo( int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
          
            detailsPersonUser1.PersonID = PersonID;

        }

        private void DetailsUserAndPersonInfo_Load(object sender, EventArgs e)
        {
          
           
           
        }

        private void detailsPersonUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
