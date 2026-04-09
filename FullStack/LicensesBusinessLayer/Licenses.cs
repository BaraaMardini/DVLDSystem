using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensesBusinessLayer
{
    public class Licenses
    {


        static public bool CheakLicenseIDIfLicenseClassIs3(int LicenseID, int LicenseClass)
        {
            return LicensesData.CheakLicenseIDIfLicenseClassIs3(LicenseID, LicenseClass);
        }
        static public bool CheakTheLicenseIDIsActive(int LicenseID)
        {
            return LicensesData.CheakTheLicenseIDIsActive(LicenseID);
        }


        static public void UpdatePersonInfo(int LicenseID)
        {
           LicensesData.UpdatePersonInfo(LicenseID);
        }
        static public int GetLicenseClassByLicenseID(int LicenseID)
        {
            return LicensesData.GetLicenseClassByLicenseID(LicenseID);
        }


        static public DateTime GetExpirationDateByLicenseID(int LicenseID)
        {
            return LicensesData.GetExpirationDateByLicenseID(LicenseID);
        }

        static public bool FindTheLicenseIDByLicenseID(int LicenseID)
        {
            return LicensesData.FindTheLicenseIDByLicenseID(LicenseID);
        }
        static public bool CheckClass3LocalLicense(int LicenseID)
        {
            return LicensesData.CheckClass3LocalLicense(LicenseID);
        }


        static public DataTable GetInfoLicense(int DriverID)
        {
            return LicensesData.GetInfoLicense(DriverID);
        }

        static public int GetLicenseIDByLocalDrivingLicenseApplications(int LocalDrivingLicenseApplications)
        {
            return LicensesData.GetLicenseIDByLocalDrivingLicenseApplications(LocalDrivingLicenseApplications);
        }



        static public int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {

           return   LicensesData.AddNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);

        }

    }
}
