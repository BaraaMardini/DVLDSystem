using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class DVLD
    {
        static public bool IsThePersonDrive(int PersonID)
        {
            return DVLD_Data.IsThePersonDrive(PersonID);
        }
        static public int CountOfTestRepeat(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
           return  DVLD_Data.CountOfTestRepeat(LocalDrivingLicenseApplicationID, TestTypeID);
        }
    
        static public bool ValidateNewLocalApplication(string LicenseClass, int PersonID)
        {
            return DVLD_Data.ValidateNewLocalApplication(LicenseClass, PersonID);
        }


        static public DataTable GetAllLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            return DVLD_Data.GetAllLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);
        }

        static public int GetPassedTestCountByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return DVLD_Data.GetPassedTestCountByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }


    }
}
