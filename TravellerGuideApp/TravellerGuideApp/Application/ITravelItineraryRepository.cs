using Domain.Entities;
namespace Application
{
    public interface ITravelItineraryRepository
    {
        void CreateTravelItinerary(TravelItinerary travelItineary);
        void UpdateTravelItinerary(int travelItinerary_ID, TravelItinerary travelItineary);
        void DeleteTravelItinerary(int travelItinerary_ID);
        TravelItinerary GetTravelItinerary(int travelItinerary_ID);
        IEnumerable<TravelItinerary> GetAllTravelItineraries();
    }
}
