using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriversDataAccess;
namespace DriversBusiness
{
    public class clsDriver
    {
       
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public clsDriver() {
            DriverID = -1;
            CreatedByUserID = -1;
            PersonID = -1;
        }
        private clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        public static bool IsExistsDriver(int PersonID)
        {
            return clsDriverDataAccess.IsDriverExists(PersonID);
        }

        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
           return (clsDriverDataAccess.AddDriver(PersonID, CreatedByUserID, CreatedDate));
        }

        public static int GetDriverID(int PersonID)
        {
            return clsDriverDataAccess.GetDriverID(PersonID);
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }
    }
}
