using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ILocationRepository
    {
        void Create(Location location);
        void Update(Location location);
        void Delete(int locationId);
        Location GetById(int locationId);
        IEnumerable<Location> GetLocationsForCity(int cityId);
    }
}
