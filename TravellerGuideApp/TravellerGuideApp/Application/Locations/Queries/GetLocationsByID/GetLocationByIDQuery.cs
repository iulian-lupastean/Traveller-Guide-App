using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Locations.Queries.GetLocationsByID
{
    public class GetLocationByIdQuery : IRequest<Location>
    {
        public int Id { get; set; }
    }
}
