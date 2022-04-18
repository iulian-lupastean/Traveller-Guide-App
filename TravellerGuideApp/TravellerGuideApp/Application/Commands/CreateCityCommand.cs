using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Commands
{
    public class CreateCityCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
