using InternationalLicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InternationalLicensesBusinessLayer
{
    public class InternationalLicenses
    {

        static public DataTable GetInterNationalLicenseByIssuedUsingLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            return InternationalLicensesData.GetInterNationalLicenseByIssuedUsingLocalLicenseID(IssuedUsingLocalLicenseID);
        }
        static public DataTable GetAllInternationalLicenses()
        {
            return InternationalLicensesData.GetAllInternationalLicenses();
        }
        static public DataTable GetInterNationalLicenseByILID(int InternationalLicenseID)
        {
            return InternationalLicensesData.GetInterNationalLicenseByILID(InternationalLicenseID);
        }
        static public bool FindTheInternationalLicenseByLicenseID(int IssuedUsingLocalLicenseID)
        {


            return InternationalLicensesData.FindTheInternationalLicenseByLicenseID(IssuedUsingLocalLicenseID);
        }
        static public int AddNewInternationalLicense(int ApplicationID, int IssuedUsingLocalLicenseID, int IsActive, DateTime IssueDate, int CreatedByUserID, DateTime ExpirationDate, int DriverID)
        {

            return InternationalLicensesData.AddNewInternationalLicense(ApplicationID, IssuedUsingLocalLicenseID, IsActive, IssueDate, CreatedByUserID, ExpirationDate,DriverID);

        }





    }
}
