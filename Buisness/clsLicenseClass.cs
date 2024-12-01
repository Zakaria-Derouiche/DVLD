using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LicenseClassesDataAccess;

namespace LicenseClassesBusiness
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string LicenseClassName { get; set; }
        public string LicenseClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        public clsLicenseClass() { }
        private clsLicenseClass(int LicenseClassID, string LicenseClassName, string LicenseClassDescription, int MinimumAllowedAge,
            int DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;
            this.LicenseClassDescription = LicenseClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }
       
        public static string[] GetAllClassesName()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClassesNames();
        }
      
        public static clsLicenseClass GetLicenseClassInfo(string ClassName)
        {
            int ClassID = -1;
            string ClassDecription = string.Empty;
            byte MinAllowesdAge = 0;
            decimal LicenseFees = 0;
            byte LicenseLength = 0;
            if (clsLicenseClassDataAccess.GetLicenseInfo(ClassName, ref ClassID, ref ClassDecription, ref LicenseFees,
                ref MinAllowesdAge, ref LicenseLength))
                return new clsLicenseClass(ClassID, ClassName, ClassDecription, MinAllowesdAge, LicenseLength, LicenseFees);
            else
                return null;
        }
        public static byte GetLicenseDefaultValidityLength(int LicenseClassID)
        {
            byte DefaultValidityLenth = 0;
            if(clsLicenseClassDataAccess.GetLicenseValidityLength(LicenseClassID, ref DefaultValidityLenth))
                return DefaultValidityLenth;
            return 0;
        }
        public static string GetLicenseName(int LicenseClassID)
        {
            string LicenseName = string.Empty;
            if (clsLicenseClassDataAccess.GetLicenseName(LicenseClassID, ref LicenseName))
                return LicenseName;
            return "";
        }
        public static decimal GetLicenseClassFees(int LicenseClassID)
        {
            return clsLicenseClassDataAccess.GetLicenseClassFees(LicenseClassID);
        }
    }
}
