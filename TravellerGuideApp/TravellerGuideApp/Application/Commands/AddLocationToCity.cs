using MediatR;

namespace TravelerGuideApp.Application.Commands
{
    public class AddLocationToCity : IRequest<int>
    {
        public int CityId { get; set; }
        public int LocationId { get; set; }
    }
}
