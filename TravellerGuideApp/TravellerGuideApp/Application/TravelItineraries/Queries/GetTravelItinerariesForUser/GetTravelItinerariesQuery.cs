using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Queries.GetTravelItinerariesForUser
{
    public class GetTravelItinerariesQuery : IRequest<IEnumerable<TravelItineraryVm>>
    {
        public int UserId { get; set; }
    }
}
