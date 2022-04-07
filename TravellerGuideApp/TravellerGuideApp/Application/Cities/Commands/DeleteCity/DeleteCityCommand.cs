using MediatR;

namespace Application.Cities.Commands.DeleteCityByID
{
    public class DeleteCityCommand : IRequest<int>
    {
        public int ID { get; set; }
    }
}
