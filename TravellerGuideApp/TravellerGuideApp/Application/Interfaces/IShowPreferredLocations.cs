using Domain;

namespace Application
{
    public interface IShowPreferredLocations
    {
        IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations);
    }
}
