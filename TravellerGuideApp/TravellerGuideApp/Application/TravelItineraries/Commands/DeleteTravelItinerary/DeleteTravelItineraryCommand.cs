using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.DeleteTravelItinerary
{
    public class DeleteTravelItineraryCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
