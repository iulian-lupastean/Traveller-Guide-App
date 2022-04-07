using Domain.Entities;
using MediatR;
namespace Application.Cities.Queries.GetCityByID
{
    public class GetCityByIDQuery : IRequest<City>
    {
        public int ID { get; set; }
    }
}
