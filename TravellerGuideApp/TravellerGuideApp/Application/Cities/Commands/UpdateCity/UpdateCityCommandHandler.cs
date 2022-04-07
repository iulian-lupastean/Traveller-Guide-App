using Domain.Entities;
using MediatR;

namespace Application.Cities.Commands.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly ICityRepository _repository;

        public UpdateCityCommandHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(UpdateCityCommand command, CancellationToken cancellationToken)
        {
            var city = new City(command.Name, command.Country);
            _repository.UpdateCity(city);
            return Task.FromResult(city.ID);
        }
    }
}