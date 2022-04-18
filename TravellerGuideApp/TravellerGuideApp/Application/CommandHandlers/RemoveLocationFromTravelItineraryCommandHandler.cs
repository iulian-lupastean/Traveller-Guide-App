using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;

namespace TravelerGuideApp.Application.CommandHandlers
{
    public class RemoveLocationFromTravelItineraryCommandHandler : IRequestHandler<RemoveLocationFromTravelitinerary, int>
    {
        ITravelItineraryRepository _repository;

        public RemoveLocationFromTravelItineraryCommandHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(RemoveLocationFromTravelitinerary command, CancellationToken cancellationToken)
        {
            _repository.RemoveLocationsFromTravelItinerary(command.TravelItineraryId, command.LocationId);
            _repository.Save();
            return Task.FromResult(command.TravelItineraryId);
        }
    }
}
