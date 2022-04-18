using MediatR;

namespace TravelerGuideApp.Application.Commands
{
    public class RemoveLocationFromCity : IRequest<int>
    {
        public int CityId { get; set; }
        public int LocationId { get; set; }
    }
}
