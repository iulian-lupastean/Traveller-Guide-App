using MediatR;

namespace TravelerGuideApp.Application.Cities.Queries.GetCities
{
    public class GetCitiesListQuery : IRequest<IEnumerable<CitiesListVm>>
    {
    }
}
