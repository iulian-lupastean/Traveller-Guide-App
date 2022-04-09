using MediatR;

namespace TravelerGuideApp.Application.Cities.Commands.CreateCity
{
    public class CreateCityCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
