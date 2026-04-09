using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataAccessLayer;
namespace TestBusinessLayer
{
    public class Test
    {

        static public void AddNewTest(int TestAppointmentID, int TestResult, string Notes, int CreatedByUserID)
        {
            TestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        static public DataTable GetOnlyTestTypeByID(int TestTypeID)
        {
            return TestData.GetOnlyTestTypeByID(TestTypeID);
        }


        static public bool FindTheTestByUserID(int UserID)
        {
            return TestData.FindTheTestByUserID(UserID);
        }


        static public DataTable GetAllTestType()
        {
            return TestData.GetAllTestType();
        }

        static public void UpdateApplicationType(int TestTypeID, string TestTypeFees, string TestTypeDescription, string TestTypeTitle)
        {
            TestData.UpdateTestType(TestTypeID, TestTypeFees, TestTypeDescription, TestTypeTitle);
        }


        static public  decimal GetFeesTypeByTestTypeID(int TestTypeID)
        {
            return TestData.GetFeesTypeByTestTypeID(TestTypeID);
        }


    }
}
