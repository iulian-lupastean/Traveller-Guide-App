using Domain;

namespace Application
{

    public class ShowFamousBuildingFirst : IShowPreferredLocations
    {
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            var showLocations = locations
                .Where(x => x.City_ID.Equals(city.ID)).OrderByDescending(x => x.Location_Type == "Famous Building")
                .ThenBy(x => x.Location_Type)
                .Select(x => x);
            return showLocations;
        }
    }
}
