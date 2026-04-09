using DriverDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverBusinessLayer
{
    public class Driver
    {

        static public DataTable GetAllDataDriver()
        {
            return DriverData.GetAllDataDriver();
        }
        static public DataTable GetDataDriver(int LicenseID)
        {

            return DriverData.GetDataDriver(LicenseID);
        }

        static public int GetDriverIDByPersonID(int PersonID)
        {
            return DriverData.GetDriverIDByPersonID(PersonID);
        }


        static public int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            return DriverData.AddNewDriver(PersonID, CreatedByUserID, CreatedDate); 
        }

        static public bool FindTheDriverByUserID(int UserID)
        {

         return   DriverData.FindTheDriverByUserID(UserID);

        }





    }
}
