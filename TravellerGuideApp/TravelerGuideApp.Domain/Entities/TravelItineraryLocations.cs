namespace TravelerGuideApp.Domain.Entities
{
    public class TravelItineraryLocations
    {
        public int Id { get; set; }
        public int TravelItineraryId { get; set; }
        public int LocationId { get; set; }
        public TravelItinerary? TravelItinerary { get; set; } = null;
        public Location? Location { get; set; } = null;
    }
}
