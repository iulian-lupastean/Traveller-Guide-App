using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.CreateTravelItinerary
{
    public class CreateTravelItineraryCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Travel_Date { get; set; }
    }
}
