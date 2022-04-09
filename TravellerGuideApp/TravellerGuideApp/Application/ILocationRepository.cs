using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ILocationRepository
    {
        void CreateLocation(Location location);
        void UpdateLocation(Location location);
        void DeleteLocation(int locationId);
        Location GetLocationById(int locationId);
        IEnumerable<Location> GetLocationsForCity(int cityId);
    }
}
