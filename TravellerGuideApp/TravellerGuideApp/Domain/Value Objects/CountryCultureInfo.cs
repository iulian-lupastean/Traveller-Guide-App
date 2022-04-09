
namespace TravelerGuideApp.Domain.Value_Objects
{
    public class CountryList
    {
        public static Dictionary<string, string> GetCultureInfo()
        {
            Dictionary<string, string> countryList = new Dictionary<string, string>();
            countryList.Add("France", "fr-FR");
            countryList.Add("United Kingdom", "en-GB");
            countryList.Add("Spain", "es-ES");
            return countryList;
        }
    }

}
