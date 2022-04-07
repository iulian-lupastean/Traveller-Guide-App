using MediatR;

namespace Application.Cities.Commands.CreateCity
{
    public class CreateCityCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
