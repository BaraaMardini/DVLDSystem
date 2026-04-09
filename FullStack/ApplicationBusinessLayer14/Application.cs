using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDataAccessLayer;

namespace ApplicationBusinessLayer14
{
    public class Application14
    {


        static public int AddNewRetakeApplication(int PersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

         return ApplicationData.AddNewRetakeApplication(PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }



        static public decimal GetFeesApplicationByApplicationTypeID(int ApplicationTypeID)
        {

       return ApplicationData.GetFeesApplicationByApplicationTypeID(ApplicationTypeID);

        }








        static public void UpdateStatusAndLastStatusDate(int ApplicationID, int Status, DateTime DateTime)
        {

           ApplicationData.UpdateStatusAndLastStatusDate(ApplicationID, Status, DateTime);
            
        }

        static public int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, int CreatedByUserID, decimal PaidFees)
        {

           return ApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,LastStatusDate, CreatedByUserID, PaidFees);
        }



        static public void UpdateApplicationType(int ApplicationID, string ApplicationTitle, string ApplicationFees)
        {
            ApplicationData.UpdateApplicationType(ApplicationID, ApplicationTitle, ApplicationFees);    

        }




        static public DataTable GetAllApplicationType()
        {
            return ApplicationData.GetAllApplicationType();
        }

        static public DataTable GetOnlyApplicationTypeByID(int ApplicationID)
        {

            return ApplicationData.GetOnlyApplicationTypeByID(ApplicationID);
        }





        static public bool FindTheApplicationByUserID(int UserID)

        { 
        return ApplicationData.FindTheApplicationByUserID(UserID);
        }



    }



}
