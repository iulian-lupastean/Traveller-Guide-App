using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
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
            var travelItinerary = new TravelItinerary(command.Id, command.Name, command.Status, command.TravelDate);
            _repository.Update(travelItinerary);
            _repository.Save();
            return Task.FromResult(travelItinerary.Id);
        }
    }
}
