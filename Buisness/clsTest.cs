using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsDataAccess;

namespace TestsBusiness
{
    public class clsTest
    {
        //public int TestID { get; set; }
        //public int TestAppintmentID {  get; set; }
        //public bool TestResult { get; set; }
        //public string Notes { get; set; }
        //public int CreatedByUserID { get; set; }

        public static bool AddTest(ref int TestID, int TestAppointmentID, bool TestResut, string Notes, int CreatedByUserID)
        {
            return clsTestDataAccess.AddNewTest(ref TestID, TestAppointmentID, TestResut, Notes, CreatedByUserID);
        }
    }
}
