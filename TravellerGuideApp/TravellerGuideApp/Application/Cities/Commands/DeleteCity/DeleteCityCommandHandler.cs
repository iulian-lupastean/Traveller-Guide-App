using MediatR;

namespace TravelerGuideApp.Application.Cities.Commands.DeleteCity
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, int>
    {
        private readonly ICityRepository _repository;

        public DeleteCityCommandHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(DeleteCityCommand query, CancellationToken cancellationToken)
        {
            _repository.DeleteCity(query.Id);

            return Task.FromResult(query.Id);
        }

    }
}