using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Queries.GetTravelItinerariesForUser
{
    public class GetTravelItinerariesQueryHandler : IRequestHandler<GetTravelItinerariesQuery, IEnumerable<TravelItineraryVm>>
    {
        private readonly ITravelItineraryRepository _repository;

        public GetTravelItinerariesQueryHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<TravelItineraryVm>> Handle(GetTravelItinerariesQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetAll(query.UserId).Select(travelItinerary => new TravelItineraryVm
            {
                Id = travelItinerary.Id,
                Name = travelItinerary.Name,
                Status = travelItinerary.Status,
                TravelDate = travelItinerary.TravelDate
            });

            return Task.FromResult(result);
        }
    }
}
