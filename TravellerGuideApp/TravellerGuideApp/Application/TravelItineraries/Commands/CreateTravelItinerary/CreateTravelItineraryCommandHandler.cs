using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.CreateTravelItinerary
{
    public class CreateTravelItineraryCommandHandler : IRequestHandler<CreateTravelItineraryCommand, int>
    {

        private readonly ITravelItineraryRepository _repository;

        public CreateTravelItineraryCommandHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Handle(CreateTravelItineraryCommand command, CancellationToken cancellationToken)
        {
            var travelItinerary = new TravelItinerary(command.Name, command.Status, command.Travel_Date);
            _repository.CreateTravelItinerary(travelItinerary);

            return Task.FromResult(travelItinerary.Id);
        }
    }
}
