using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsTypesDataAccess;

namespace TestsTypesBusiness
{
    public class clsTestType
    {
        public int TestTypeID {  get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        public clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }
        public static DataTable GetAllTestsTypeInfo()
        {
            return clsTestTypeDataAccess.GetTestsTypesInfo();
        }

        public bool UpdateTestTypeInfo()
        {
            return clsTestTypeDataAccess.UpdateTestTypeInfo(this.TestTypeID, this.TestTypeTitle,
                this.TestTypeDescription, this.TestTypeFees);
        }
        public static decimal GetTestTypeFees(int TestTypeID)
        {
            decimal TestFees = 0;
            if (clsTestTypeDataAccess.GetTestTypeFees(TestTypeID, ref TestFees))
                return TestFees;
            return 0;
        }
    }
}
