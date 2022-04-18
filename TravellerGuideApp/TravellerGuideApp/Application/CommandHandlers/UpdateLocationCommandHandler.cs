using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
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
            var location = new Location(command.Id, command.Name, command.Address, command.LocationType, command.Price, command.Latitude, command.Longitude, command.CityId);
            _repository.Update(location);
            _repository.Save();
            return Task.FromResult(location.Id);
        }
    }
}
