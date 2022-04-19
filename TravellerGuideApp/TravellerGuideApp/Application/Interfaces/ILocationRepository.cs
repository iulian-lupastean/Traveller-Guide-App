using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Interfaces
{
    public interface ILocationRepository
    {
        void Create(Location location);
        void Update(Location location);
        void Delete(int locationId);
        Location GetById(int locationId);
        IEnumerable<Location> GetLocationsForCity();
        public void Save();
    }
}
