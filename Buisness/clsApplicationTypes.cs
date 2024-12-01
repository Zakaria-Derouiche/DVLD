using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsTypeDataAccess;

namespace ApplicationsBusiness
{
    public class clsApplicationTypes
    {
        public int ApplcationTypeID {  get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationTypeFees { get; set; }
        public clsApplicationTypes(){}
        public clsApplicationTypes(int applcationTypeID, string applicationTypeTitle, decimal applicationTypeFees)
        {
            this.ApplcationTypeID = applcationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationTypeFees = applicationTypeFees;
        }

        public static clsApplicationTypes GetApplictionTypeInfoByType(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = string.Empty;
            decimal ApplicationTypeFees = 0;
            bool IsFound = clsApplicationTypeDataAccess.GetApplicationTypeInfo(  ApplicationTypeID, ref ApplicationTypeTitle,
                ref ApplicationTypeFees);
            if(IsFound)
                return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
            else 
                return null;
        }
        public static DataTable GetApplicationTypes()
        {
            return clsApplicationTypeDataAccess.GetApplicationTypes();
        }

        public bool UpdateApplicationType()
        {
            return clsApplicationTypeDataAccess.UpdateApllicationType(ApplcationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
        }
        public static decimal GetApplicationTypeFees(int ApplicationTypeID)
        {
            decimal ApplicationTypeFees = 0;
            return (clsApplicationTypeDataAccess.GetApplicationTypeFees(ApplicationTypeID, ref ApplicationTypeFees)) ?
                ApplicationTypeFees : 0;
        }
        public static string GetApplicationTitle(int ApplicationTypeID)
        {
            string Title = string.Empty;
            return (clsApplicationTypeDataAccess.GetApplicationTypeTitle(ApplicationTypeID, ref Title)) ?
                Title : "";
        }
    }
}
