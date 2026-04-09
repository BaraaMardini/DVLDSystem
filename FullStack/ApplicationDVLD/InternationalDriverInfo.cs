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
    public partial class InternationalDriverInfo : Form
    {
        int InternationalLicenseID;
        public InternationalDriverInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            this.InternationalLicenseID = InternationalLicenseID;
        }

        private void InternationalDriverInfo_Load(object sender, EventArgs e)
        {
            infoInternationalLicense1.GetInternationalID(InternationalLicenseID);
            MessageBox.Show(InternationalLicenseID.ToString());
            infoInternationalLicense1.StoreTheDataInControl();
            

        }
    }
}
