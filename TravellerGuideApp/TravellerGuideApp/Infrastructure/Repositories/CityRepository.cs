using Microsoft.EntityFrameworkCore;
using TravelerGuideApp.Application;
using TravelerGuideApp.Domain.Entities;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;

namespace TravelerGuideApp.Infrastructure.Repositories
{
    public class CityRepository : ICityRepository, IDisposable
    {
        private TravelerGuideAppDBContext context;

        public CityRepository(TravelerGuideAppDBContext context)
        {
            this.context = context;
        }

        public void Create(City city)
        {
            context.Cities.Add(city);
        }

        public void Update(City city)
        {
            context.Entry(city).State = EntityState.Modified;
        }

        public void Delete(int CityId)
        {
            City city = context.Cities.Find(CityId);
            context.Cities.Remove(city);
        }

        public City GetById(int CityId)
        {
            return context.Cities.Find(CityId);
        }

        public IEnumerable<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                { context.Dispose(); }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
