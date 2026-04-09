using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestAppointmentDataAccessLayer;

namespace TestAppointmentBusinessLayer
{
    public class TestAppointment
    {

        static public bool GetLastPassedTestAppointmentID(int TestResult, int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
           return   TestAppointmentData.GetLastPassedTestAppointmentID(TestResult, LocalDrivingLicenseApplicationID,TestTypeID);
        }

        static public void UpdateTestAppointment(int TestAppointmentID)
        {
            TestAppointmentData.UpdateTestAppointment(TestAppointmentID);
        }


        static public DateTime GetAppointmentDateByAppointmentID(int TestAppointmentID)
        {
            return TestAppointmentData.GetAppointmentDateByAppointmentID(TestAppointmentID);
        }


        static public void AddNewAppointment(int TestTypeID, int LocalDrivingApplication, DateTime AppointmentDate,decimal Fees, int CreatedByUserID, int IsLocked, int RetakeTestApplicationID)
        {
          TestAppointmentData.AddNewAppointment(TestTypeID, LocalDrivingApplication, AppointmentDate, Fees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

        }
        static public  int  GetLastTestAppointmentID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestAppointmentData.GetLastTestAppointmentID(LocalDrivingLicenseApplicationID, TestTypeID);  
        }


        static public bool FindTheTestAppointmentIfLocked(int IsLocked, int LocalDrivingLicenseApplicationID,string ClassName, int TestTypeID)
        {
            return TestAppointmentData.FindTheTestAppointmentIfLocked(IsLocked, LocalDrivingLicenseApplicationID,ClassName,TestTypeID);
        }


        public static DataTable GetTestAppointmentByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return TestAppointmentData.GetTestAppointmentByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID , TestTypeID);
        }

        static public bool IsTestTypeActive(int IsLocked, int TestTypeID,string ClassName, int  LocalDrivingLicenseApplicationID)
        {
            return TestAppointmentData.IsTestTypeActive(IsLocked, TestTypeID, ClassName,LocalDrivingLicenseApplicationID);  
        }


    }
}




