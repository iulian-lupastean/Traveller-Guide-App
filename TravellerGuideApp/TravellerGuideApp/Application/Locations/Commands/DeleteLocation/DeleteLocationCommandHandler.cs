using MediatR;

namespace TravelerGuideApp.Application.Locations.Commands.DeleteLocation
{
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand, int>
    {
        private readonly ILocationRepository _repository;

        public DeleteLocationCommandHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(DeleteLocationCommand query, CancellationToken cancellationToken)
        {
            _repository.Delete(query.Id);
            return Task.FromResult(query.Id);
        }
    }
}
