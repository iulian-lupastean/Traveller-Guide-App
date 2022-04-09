using MediatR;

namespace TravelerGuideApp.Application.Locations.Queries.GetLocations
{
    public class GetLocationsListQuery : IRequest<IEnumerable<LocationsListVm>>
    {
        public int CityId { get; set; }
    }
}
