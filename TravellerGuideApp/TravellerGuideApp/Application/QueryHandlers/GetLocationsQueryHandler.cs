using MediatR;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Application.Queries;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.QueryHandlers
{
    public class GetLocationsQueryHandler : IRequestHandler<GetLocationsForCityQuery, IEnumerable<Location>>
    {
        private readonly ILocationRepository _repository;

        public GetLocationsQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Location>> Handle(GetLocationsForCityQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetLocationsForCity();

            return Task.FromResult(result);
        }
    }
}
