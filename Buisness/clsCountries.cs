using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountriesDataAccess;

namespace CountriesBusiness
{
    public class clsCountries
    {
        public static string[] CountriesList()
        {
            return clsCountriesAccess.GetAllCountries();
        }
        public static string GetCountryDialingCode(string CountryName)
        {
            return clsCountriesAccess.GetCountryDialingCode(CountryName);
        }
    }
}
