using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ITravelItineraryRepository
    {
        void CreateTravelItinerary(TravelItinerary travelItinerary);
        void UpdateTravelItinerary(TravelItinerary travelItinerary);
        void DeleteTravelItinerary(int travelItineraryId);
        TravelItinerary GetTravelItinerary(int travelItineraryId);
        IEnumerable<TravelItinerary> GetAllTravelItineraries(int userId);
    }
}
