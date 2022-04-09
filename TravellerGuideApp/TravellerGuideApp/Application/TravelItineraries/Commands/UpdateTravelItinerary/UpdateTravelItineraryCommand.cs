using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.UpdateTravelItinerary
{
    public class UpdateTravelItineraryCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
