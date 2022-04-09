using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Locations.Commands.UpdateLocation
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, int>
    {
        private readonly ILocationRepository _repository;

        public UpdateLocationCommandHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(UpdateLocationCommand command, CancellationToken cancellationToken)
        {
            var location = new Location(command.Name, command.Address, command.LocationType, command.Price, command.Latitude, command.Longitude);
            _repository.UpdateLocation(location);
            return Task.FromResult(location.Id);
        }
    }
}
