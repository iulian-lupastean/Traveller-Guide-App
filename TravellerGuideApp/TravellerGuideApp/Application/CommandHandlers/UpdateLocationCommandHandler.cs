using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, Location>
    {
        private readonly ILocationRepository _repository;

        public UpdateLocationCommandHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<Location> Handle(UpdateLocationCommand command, CancellationToken cancellationToken)
        {
            var location = _repository.GetById(command.Id);
            location.Name = command.Name;
            location.Address = command.Address;
            location.LocationType = command.LocationType;
            location.Price = command.Price;
            location.CityId = command.CityId;
            location.Latitude = command.Latitude;
            location.Longitude = command.Longitude;
            _repository.Update(location);
            _repository.Save();
            return Task.FromResult(location);
        }
    }
}
