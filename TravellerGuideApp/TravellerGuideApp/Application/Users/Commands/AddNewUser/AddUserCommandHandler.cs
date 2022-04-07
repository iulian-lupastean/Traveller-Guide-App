using Domain.Entities;
using MediatR;
namespace Application.Users.Commands.AddNewUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
    {
        private readonly IUserRepository _repository;

        public AddUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Handle(AddUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User(command.FirstName, command.LastName, command.Email, command.Password, command.User_Type);
            _repository.CreateUser(user);

            return Task.FromResult(user.ID);
        }
    }
}

