using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.TravelItineraries.Queries.GetTravelItineraryByID
{
    public class GetTravelItineraryByIdQuery : IRequest<TravelItinerary>
    {
        public int Id { get; set; }
    }
}
