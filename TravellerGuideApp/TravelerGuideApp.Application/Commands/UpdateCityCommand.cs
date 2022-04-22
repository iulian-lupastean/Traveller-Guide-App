using MediatR;

namespace TravelerGuideApp.Application.Commands
{
    public class UpdateCityCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
    }
}
