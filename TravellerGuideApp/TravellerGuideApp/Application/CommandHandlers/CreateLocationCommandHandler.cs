using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
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
            var location = new Location(command.Name, command.Address, command.LocationType, command.Price, command.Latitude, command.Longitude);
            _repository.Create(location);
            _repository.Save();
            return Task.FromResult(location.Id);
        }
    }
}
