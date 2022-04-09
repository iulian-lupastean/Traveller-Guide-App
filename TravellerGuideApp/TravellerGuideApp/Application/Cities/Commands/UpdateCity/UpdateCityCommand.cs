using MediatR;

namespace TravelerGuideApp.Application.Cities.Commands.UpdateCity
{
    public class UpdateCityCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
