using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class CountryList
    {
        public static Dictionary<string, string> GetCultureInfo()
        {
            Dictionary<string, string> CountryList = new Dictionary<string, string>();
            CountryList.Add("France", "fr-FR");
            CountryList.Add("United Kingdom", "en-GB");
            CountryList.Add("Spain", "es-ES");
            return CountryList;
        }
    }

}
