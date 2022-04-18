using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;

namespace TravelerGuideApp.Application.CommandHandlers
{
    public class AddLocationsToTravelItineraryCommandHandler : IRequestHandler<AddLocationsToTravelItinerary, int>
    {
        private readonly ITravelItineraryRepository _travelItineraryRepository;

        public AddLocationsToTravelItineraryCommandHandler(ITravelItineraryRepository travelItineraryRepository)
        {
            _travelItineraryRepository = travelItineraryRepository;
        }

        public Task<int> Handle(AddLocationsToTravelItinerary command, CancellationToken cancellationToken)
        {
            _travelItineraryRepository.AddLocationsToTravelItinerary(command.TravelItineraryId, command.LocationId);
            _travelItineraryRepository.Save();
            return Task.FromResult(command.TravelItineraryId);

        }
    }
}