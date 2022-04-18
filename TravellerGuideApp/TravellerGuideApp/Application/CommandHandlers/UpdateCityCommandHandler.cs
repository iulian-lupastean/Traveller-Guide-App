using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
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
            var city = new City(command.Id, command.Name, command.Country);
            _repository.Update(city);
            _repository.Save();
            return Task.FromResult(city.Id);
        }
    }
}