using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.TravelItineraries.Queries.GetTravelItineraryByID
{
    public class GetTravelItineraryByIdQueryHandler : IRequestHandler<GetTravelItineraryByIdQuery, TravelItinerary>
    {
        private readonly ITravelItineraryRepository _repository;

        public GetTravelItineraryByIdQueryHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }

        public Task<TravelItinerary> Handle(GetTravelItineraryByIdQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetById(query.Id);

            return Task.FromResult(result);
        }

    }
}