using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Cities.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<City>
    {
        public int Id { get; set; }
    }
}
