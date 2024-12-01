using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DetainedLicensesDataAccess;


namespace DetainedLicensesBusiness
{
    public class clsDetainedLicense
    {
        enum enMode { Add, Edit}
        private enMode _Mode;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID {  get; set; }
        public clsDetainedLicense() { }
        public clsDetainedLicense( int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID) {
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Add;
        }
        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID) {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            _Mode = enMode.Edit;
        }
        public static DataTable GetAllDetainedLicense()
        {
            return clsdetainedLicenseDataAccess.GetAllDetainedLicenses();
        }
        public static clsDetainedLicense FindDetainedLicense(int licenseID)
        {
            int detainID = -1;
            DateTime detainDate = DateTime.MaxValue;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MaxValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;
            if(clsdetainedLicenseDataAccess.FindDetainLicenseInfo(licenseID, ref detainID, ref detainDate, ref fineFees,
                ref createdByUserID, ref isReleased , ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(detainID, licenseID, detainDate, fineFees, createdByUserID, isReleased, releaseDate,
                    releasedByUserID,releaseApplicationID);
            }else
            {
                return null;
            }
        }
        public bool Save()
        {
            bool IsSaved = false;
            switch(_Mode)
            {
                case enMode.Add:
                    int DetID = -1;
                    IsSaved = clsdetainedLicenseDataAccess.AddDetainLicense(ref DetID, LicenseID, DetainDate, FineFees,
                        CreatedByUserID, IsReleased);
                    DetainID = DetID;
                    _Mode = IsSaved ?enMode.Edit : enMode.Add;
                    break;
                case enMode.Edit:
                    IsSaved = clsdetainedLicenseDataAccess.UpdateDetainedLicesne(DetainID, ReleaseDate, ReleasedByUserID,
                        ReleaseApplicationID);
                    break;
            }
            return IsSaved;
        }
        public static bool IsDetainedLicence(int LicenceID)
        {
            return clsdetainedLicenseDataAccess.IsDetainedLicesne(LicenceID);
        }

    }
}
