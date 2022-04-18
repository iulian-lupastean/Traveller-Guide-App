using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;

namespace TravelerGuideApp.Application.CommandHandlers
{
    public class AddLocationToCityCommandHandler : IRequestHandler<AddLocationToCity, int>
    {
        private readonly ILocationRepository _locationRepository;

        public AddLocationToCityCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public Task<int> Handle(AddLocationToCity command, CancellationToken cancellationToken)
        {
            _locationRepository.AddLocationToCity(command.CityId, command.LocationId);
            _locationRepository.SetIdentityOn();
            _locationRepository.Save();
            _locationRepository.SetIdentityOff();
            return Task.FromResult(command.LocationId);

        }
    }
}
