using Domain;

namespace Application
{
    public class FilterLocationsContexts
    {
        private IShowPreferredLocations _strategy;
        public void SeeStrategy(IShowPreferredLocations strategy)
        {
            _strategy = strategy;
        }
        public IEnumerable<Location> ShowPreferedLocations(City city, IEnumerable<Location> locations)
        {
            if (_strategy == null)
            {
                return null;
            }
            else
            {
                return _strategy.ShowPreferedLocations(city, locations);
            }
        }
    }
}



