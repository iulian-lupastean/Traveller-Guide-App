using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Interfaces
{
    public interface ILocationRepository
    {
        void Create(Location location);
        void Update(Location location);
        void Delete(int locationId);
        void AddLocationToCity(int cityId, int locationId);
        void RemoveLocationFromCity(int cityId, int locationId);
        void SetIdentityOn();
        void SetIdentityOff();
        Location GetById(int locationId);
        IEnumerable<Location> GetLocationsForCity();
        public void Save();
    }
}
