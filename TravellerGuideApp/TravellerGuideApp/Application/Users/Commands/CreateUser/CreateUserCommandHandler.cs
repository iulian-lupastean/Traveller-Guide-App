using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _repository;

        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User(command.FirstName, command.LastName, command.Email, command.Password, command.UserType);
            _repository.CreateUser(user);

            return Task.FromResult(user.Id);
        }
    }
}

