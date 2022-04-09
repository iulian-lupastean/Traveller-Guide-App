using MediatR;

namespace TravelerGuideApp.Application.Locations.Queries.GetLocations
{
    public class GetLocationsQueryHandler : IRequestHandler<GetLocationsListQuery, IEnumerable<LocationsListVm>>
    {
        private readonly ILocationRepository _repository;

        public GetLocationsQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<LocationsListVm>> Handle(GetLocationsListQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetLocationsForCity(query.CityId).Select(location => new LocationsListVm
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                LocationType = location.LocationType,
                Price = location.Price,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
            });
            return Task.FromResult(result);
        }
    }
}
