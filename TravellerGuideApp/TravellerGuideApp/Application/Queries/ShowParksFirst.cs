using Domain;
namespace Application
{
    public class ShowParksFirs : IShowPreferredLocations
    {
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            var showLocations = locations
                .Where(x => x.City_ID.Equals(city.ID)).OrderByDescending(x => x.Location_Type == "Museum")
                .ThenBy(x => x.Location_Type)
                .Select(x => x);
            return showLocations;
        }

    }
}
