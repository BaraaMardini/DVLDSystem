using LocalDrivingApplicationDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDrivingApplicationBusinessLayer
{
    public class LocalDrivingApplication
    {


        static public int GetPersonIDByLocalDrivingApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return LocalDrivingApplicationData.GetPersonIDByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID);
        }

        static public DataTable GetAllLocalDrivingApplicationData()
        {
            return LocalDrivingApplicationData.GetAllLocalDrivingApplicationData();
        }

        static public int AddNewLocalDrivingApplication(int ApplicationID, int LicenseClassID)
        {
            return LocalDrivingApplicationData.AddNewLocalDrivingApplication(ApplicationID, LicenseClassID);
        }

        static public int GetApplicationIDByLocalDriveApplicationID(int LocalDriveApplicationID)
        {
            return LocalDrivingApplicationData.GetApplicationIDByLocalDriveApplicationID(LocalDriveApplicationID);
        }

    

    }
}
