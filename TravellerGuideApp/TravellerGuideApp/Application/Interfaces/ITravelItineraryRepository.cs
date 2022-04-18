using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Interfaces
{
    public interface ITravelItineraryRepository
    {
        void Create(TravelItinerary travelItinerary);
        void CreateTravelItineraryLocation(TravelItinerary travelItinerary);
        void Update(TravelItinerary travelItinerary);
        void Delete(int travelItineraryId);
        void AddLocationsToTravelItinerary(int travelItineraryId, int locationId);
        void RemoveLocationsFromTravelItinerary(int travelItineraryId, int locationId);
        TravelItinerary GetById(int travelItineraryId);
        IEnumerable<TravelItinerary> GetAll(int userId);
        public void Save();
    }
}
