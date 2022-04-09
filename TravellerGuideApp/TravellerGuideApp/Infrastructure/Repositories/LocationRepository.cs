using Microsoft.EntityFrameworkCore;
using TravelerGuideApp.Application;
using TravelerGuideApp.Domain.Entities;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;

namespace TravelerGuideApp.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository, IDisposable
    {
        private TravelerGuideAppDBContext context;

        public LocationRepository(TravelerGuideAppDBContext context)
        {
            this.context = context;
        }

        public void CreateLocation(Location location)
        {
            context.Locations.Add(location);
        }

        public void UpdateLocation(Location location)
        {
            context.Entry(location).State = EntityState.Modified;
        }

        public void DeleteLocation(int locationId)
        {
            Location location = context.Locations.Find(locationId);
            context.Locations.Remove(location);
        }

        public Location GetLocationById(int locationId)
        {
            return context.Locations.Find(locationId);
        }

        public IEnumerable<Location> GetLocationsForCity(int cityId)
        {
            return context.Locations.ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
