using Domain.Entities;

namespace Application
{
    public interface IItineraryLocationsRepository
    {
        void AddItineraryLocations(ItineraryLocation itinerary_Locations);
        void UpdateItineraryLocation(int itinerariLocation_ID, ItineraryLocation itinerary_Locations);
        void DeleteItineraryLocations(int itinerariLocation_ID);

    }
}
