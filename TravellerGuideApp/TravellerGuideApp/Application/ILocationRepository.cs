using Domain.Entities;

namespace Application
{
    public interface ILocationRepository
    {
        void CreateLocation(Location location);
        void UpdateLocation(int Location_ID, Location location);
        void DeleteLocation(int Location_ID, Location location);
        Location GetLocation(int Location_ID);
        IEnumerable<Location> GetAllLocations();
    }
}
