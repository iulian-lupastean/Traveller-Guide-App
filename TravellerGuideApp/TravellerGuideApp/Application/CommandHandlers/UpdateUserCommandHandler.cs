using MediatR;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.CommandHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository _repository;

        public UpdateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User(command.Id, command.FirstName, command.LastName, command.Email, command.Password, command.UserType);
            _repository.Update(user);
            _repository.Save();
            return Task.FromResult(user.Id);
        }
    }
}
