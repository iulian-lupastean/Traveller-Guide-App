using MediatR;
namespace Application.Cities.Queries.GetCities
{
    public class GetCitiesListQuery : IRequest<IEnumerable<CitiesListVm>>
    {
    }
}
