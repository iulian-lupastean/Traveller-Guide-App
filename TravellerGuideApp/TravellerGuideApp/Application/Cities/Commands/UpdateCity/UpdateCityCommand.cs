using MediatR;
namespace Application.Cities.Commands.UpdateCity
{
    public class UpdateCityCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
