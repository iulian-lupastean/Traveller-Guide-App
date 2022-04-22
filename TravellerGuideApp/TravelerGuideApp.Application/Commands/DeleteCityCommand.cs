using MediatR;

namespace TravelerGuideApp.Application.Commands
{
    public class DeleteCityCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
