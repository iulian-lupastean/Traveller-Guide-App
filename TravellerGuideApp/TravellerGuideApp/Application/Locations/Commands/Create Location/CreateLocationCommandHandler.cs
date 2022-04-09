using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Locations.Commands.Create_Location
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, int>
    {
        private readonly ILocationRepository _repository;

        public CreateLocationCommandHandler(ILocationRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Handle(CreateLocationCommand command, CancellationToken cancellationToken)
        {
            var location = new Location(command.Name, command.Address, command.Location_Type, command.Price, command.Latitude, command.Longitude);
            _repository.CreateLocation(location);

            return Task.FromResult(location.Id);
        }
    }
}
