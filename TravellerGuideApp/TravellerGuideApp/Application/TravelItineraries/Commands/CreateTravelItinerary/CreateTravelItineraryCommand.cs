using MediatR;

namespace Application.TravelItineraries.Commands
{
    public class CreateTravelItineraryCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Travel_Date { get; set; }
    }
}
