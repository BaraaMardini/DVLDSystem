using LicenseClassesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseClassesBusinessLayer
{
    public class LicenseClasses
    {


        static public int GetDefaultValidityLengthByLicenseID(int LicenseID)
        {

            return LicenseClassesData.GetDefaultValidityLengthByLicenseID(LicenseID);

        }


        static public decimal GetTheClassFeesByLicenseClass(int LicenseClass)
        {
            return LicenseClassesData.GetTheClassFeesByLicenseClass(LicenseClass);
        }
        static public decimal GetTheClassFeesByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return LicenseClassesData.GetTheClassFeesByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

        }
        static public int GetTheLicenseClassIDByClassName(string ClassName)
        {
            return LicenseClassesData.GetTheLicenseClassIDByClassName(ClassName);
        }

        static public int GetDefaultValidityLengthByClassName(string ClassName)
        {
            return LicenseClassesData.GetDefaultValidityLengthByClassName(ClassName);
        }
        public static DataTable GetAllClassName()
        {
            return LicenseClassesData.GetAllClassName();
        }


    }
}
