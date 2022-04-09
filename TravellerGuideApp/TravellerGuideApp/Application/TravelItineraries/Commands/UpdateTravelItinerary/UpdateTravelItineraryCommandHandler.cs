using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.UpdateTravelItinerary
{
    public class UpdateTravelItineraryCommandHandler : IRequestHandler<UpdateTravelItineraryCommand, int>
    {
        private readonly ITravelItineraryRepository _repository;

        public UpdateTravelItineraryCommandHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(UpdateTravelItineraryCommand command, CancellationToken cancellationToken)
        {
            var travelItinerary = new TravelItinerary(command.Name, command.Status, command.TravelDate);
            _repository.UpdateTravelItinerary(travelItinerary);
            return Task.FromResult(travelItinerary.Id);
        }
    }
}
