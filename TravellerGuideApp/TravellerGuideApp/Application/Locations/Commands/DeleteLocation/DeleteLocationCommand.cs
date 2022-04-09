using MediatR;

namespace TravelerGuideApp.Application.Locations.Commands.DeleteLocation
{
    public class DeleteLocationCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
