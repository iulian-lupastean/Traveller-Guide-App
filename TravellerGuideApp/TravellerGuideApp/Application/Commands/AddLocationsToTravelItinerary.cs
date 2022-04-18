using MediatR;
namespace TravelerGuideApp.Application.Commands
{
    public class AddLocationsToTravelItinerary : IRequest<int>
    {
        public int TravelItineraryId { get; set; }
        public int LocationId { get; set; }
    }
}
