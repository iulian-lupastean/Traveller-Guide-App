using Microsoft.EntityFrameworkCore;
using TravelerGuideApp.Application;
using TravelerGuideApp.Domain.Entities;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;

namespace TravelerGuideApp.Infrastructure.Repositories
{
    public class TravelItineraryRepository : ITravelItineraryRepository, IDisposable
    {
        private TravelerGuideAppDBContext context;

        public TravelItineraryRepository(TravelerGuideAppDBContext context)
        {
            this.context = context;
        }

        public void CreateTravelItinerary(TravelItinerary travelItinerary)
        {
            context.TravelItineraries.Add(travelItinerary);
        }

        public void UpdateTravelItinerary(TravelItinerary travelItinerary)
        {
            context.Entry(travelItinerary).State = EntityState.Modified;
        }

        public void DeleteTravelItinerary(int travelItineraryId)
        {
            TravelItinerary travelItinerary = context.TravelItineraries.Find(travelItineraryId);
            context.TravelItineraries.Remove(travelItinerary);
        }

        public IEnumerable<TravelItinerary> GetAllTravelItineraries(int userId)
        {
            return context.TravelItineraries.ToList();
        }

        public TravelItinerary GetTravelItinerary(int travelItineraryId)
        {
            return context.TravelItineraries.Find(travelItineraryId);
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
