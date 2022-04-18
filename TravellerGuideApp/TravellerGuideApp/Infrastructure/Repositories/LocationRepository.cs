using Microsoft.EntityFrameworkCore;
using TravelerGuideApp.Application;
using TravelerGuideApp.Application.Interfaces;
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

        public void Create(Location location)
        {
            context.Locations.Add(location);
        }

        public void Update(Location location)
        {
            context.Entry(location).State = EntityState.Modified;
        }

        public void Delete(int locationId)
        {
            Location location = context.Locations.Find(locationId);
            Console.WriteLine(location);
            context.Locations.Remove(location);
        }
        public void AddLocationToCity(int cityId, int locationId)
        {
            var location = context.Locations.Find(locationId);
            var city = context.Cities.Find(cityId);
            city.Locations.Add(location);
            context.Cities.Add(city);
        }

        public void RemoveLocationFromCity(int cityId, int locationId)
        {
            var location = context.Locations.Find(locationId);
            var city = context.Cities.Find(cityId);
            city.Locations.Remove(location);
            context.Cities.Update(city);
        }
        public Location GetById(int locationId)
        {
            return context.Locations.Find(locationId);
        }

        public void SetIdentityOn()
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Cities ON;");
        }

        public void SetIdentityOff()
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Cities OFF;");
        }
        public IEnumerable<Location> GetLocationsForCity()
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
