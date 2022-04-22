using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Queries
{
    public class GetLocationsForCityQuery : IRequest<IEnumerable<Location>>
    {

    }
}
