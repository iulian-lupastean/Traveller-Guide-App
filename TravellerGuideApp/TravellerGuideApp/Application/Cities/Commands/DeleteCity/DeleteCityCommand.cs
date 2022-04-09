using MediatR;

namespace TravelerGuideApp.Application.Cities.Commands.DeleteCity
{
    public class DeleteCityCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
