using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;


namespace TravelerGuideApp.Application.CommandHandlers
{
    public class RemoveLocationFromCityCommandHandler : IRequestHandler<RemoveLocationFromCity, int>
    {
        private readonly ILocationRepository _locationRepository;

        public RemoveLocationFromCityCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public Task<int> Handle(RemoveLocationFromCity command, CancellationToken cancellationToken)
        {
            _locationRepository.RemoveLocationFromCity(command.CityId, command.LocationId);
            _locationRepository.Save();
            return Task.FromResult(command.LocationId);
        }
    }
}
