using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApointementsDataAccess;
namespace TestAppointementsBusiness
{
    public class clsAppointment
    {
        enum enMode { Add, Update}
        public int AppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        private enMode _Mode;
        public clsAppointment() 
        {
            AppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            CreatedByUserID = -1;
            PaidFees = 0;
            IsLocked = false;
            _Mode = enMode.Add;
        }
        private clsAppointment(int appointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate,
            decimal paidFees, int createdByUserID, bool isLocked)
        {
            AppointmentID = appointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            _Mode = enMode.Update;
        }
        public static DataTable GetTestAppointments(int TestTypeID, int ApplicationPersonID, string ClassName)
        {
            return clsTestAppointementDataAccess.GetTestAppointments(TestTypeID, ApplicationPersonID, ClassName);
        }
        public static clsAppointment FindAppointment(int appointmentID)
        {
            int testTypeID = 0;
            int localDrivingLicenseApplicationID = 0;
            DateTime appointmentDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = 0;
            bool isLocked = false;
            bool IsFound = clsTestAppointementDataAccess.GetTestAppointment(appointmentID, ref testTypeID,
                ref localDrivingLicenseApplicationID, ref appointmentDate, ref paidFees, ref createdByUserID, ref isLocked);
            if (IsFound)
                return new clsAppointment(appointmentID, testTypeID, localDrivingLicenseApplicationID, appointmentDate
                    , paidFees, createdByUserID, isLocked);
            else
                return null;
        }
        public bool Save()
        {
            bool IsSaved = false;
            switch(_Mode)
            {
                case enMode.Add:
                    int InsertedAppointmentID = -1;
                    IsSaved = clsTestAppointementDataAccess.AddNewTestAppointement(ref InsertedAppointmentID, TestTypeID,
                        LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
                    AppointmentID = (IsSaved)? InsertedAppointmentID : -1;
                    _Mode = (IsSaved)? enMode.Update : enMode.Add;
                    break;
                case enMode.Update:
                    IsSaved = clsTestAppointementDataAccess.UpdateTestAppintementInfo(AppointmentID, AppointmentDate);
                    break;
            }
            return IsSaved;
        }
        public static bool LockTestAppointment(int TestAppointemtID)
        {
            return clsTestAppointementDataAccess.LockTestAppointment(TestAppointemtID);
        }
        public static bool IsAppointmentExists(int TestAppointmentID)
        {
            return clsTestAppointementDataAccess.IsAppointmentExists(TestAppointmentID);
        }
        public static bool IsTestAppointmentPassed(int TestApponitmentID)
        {
            return clsTestAppointementDataAccess.IsTestAppointmentsPassed(TestApponitmentID);
        }
        public static bool IsExistsOrPassedTestAppoitment(int LocalApplicationID, int TestTypeID)
        {
            return clsTestAppointementDataAccess.IsExistsOrPassedTestAppointment(LocalApplicationID, TestTypeID);
        }
    }
}
