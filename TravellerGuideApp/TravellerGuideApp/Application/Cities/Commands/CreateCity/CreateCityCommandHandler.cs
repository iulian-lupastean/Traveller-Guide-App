using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Cities.Commands.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, int>
    {
        private readonly ICityRepository _repository;

        public CreateCityCommandHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(CreateCityCommand command, CancellationToken cancellationToken)
        {
            var city = new City(command.Name, command.Country);
            _repository.Create(city);

            return Task.FromResult(city.Id);
        }
    }
}
