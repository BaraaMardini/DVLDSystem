using DetainedLicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetainedLicensesBusinessLayer
{
    public class DetainedLicenses
    {


        static public DataTable GetAllDetainedLicenses()
        {
            return DetainedLicensesData.GetAllDetainedLicenses();

        }
        static public void UpdateDetainLicense(int IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID, int LicenseID)
        {

            DetainedLicensesData.UpdateDetainLicense(IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID, LicenseID);


        }
        static public DataTable GetDetainedLicenseByLicenseID(int LicenseID)
        {
            return DetainedLicensesData.GetDetainedLicenseByLicenseID(LicenseID);
        }

        static public bool CheakLicenseIDIsReleased(int LicenseID,int IsReleased)
        {

            return DetainedLicensesData.CheakLicenseIDIsReleased(LicenseID, IsReleased);
        }

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, int IsReleased)
        {

            return DetainedLicensesData.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);
        }

    }
}
