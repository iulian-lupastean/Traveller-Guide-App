using MediatR;

namespace TravelerGuideApp.Application.TravelItineraries.Commands.DeleteTravelItinerary
{
    public class DeleteTravelItineraryCommandHandler : IRequestHandler<DeleteTravelItineraryCommand, int>
    {
        private readonly ITravelItineraryRepository _repository;

        public DeleteTravelItineraryCommandHandler(ITravelItineraryRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(DeleteTravelItineraryCommand query, CancellationToken cancellationToken)
        {
            _repository.Delete(query.Id);
            return Task.FromResult(query.Id);
        }
    }
}