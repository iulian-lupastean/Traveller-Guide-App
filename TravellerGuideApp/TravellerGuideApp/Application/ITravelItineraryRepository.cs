using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ITravelItineraryRepository
    {
        void Create(TravelItinerary travelItinerary);
        void Update(TravelItinerary travelItinerary);
        void Delete(int travelItineraryId);
        TravelItinerary GetById(int travelItineraryId);
        IEnumerable<TravelItinerary> GetAll(int userId);
    }
}
