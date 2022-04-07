using Domain.Entities;
using MediatR;

namespace Application.Cities.Commands.DeleteCityByID
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
            _repository.DeleteCity(query.ID);

            return Task.FromResult(query.ID);
        }

    }
}