using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Locations.Queries.GetLocationsByID
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, Location>
    {
        private readonly ILocationRepository _repository;

        public GetLocationByIdQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<Location> Handle(GetLocationByIdQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetLocationById(query.Id);

            return Task.FromResult(result);
        }

    }
}