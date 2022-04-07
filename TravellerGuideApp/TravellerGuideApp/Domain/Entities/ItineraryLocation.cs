namespace Domain.Entities
{
    public class ItineraryLocation
    {

        public int ID { get; set; }
        public int ItineraryID { get; set; }
        public int LocationID { get; set; }

        public TravelItinerary TravelItinerary { get; set; } = null;
        public Location Location { get; set; } = null;
    }
}
