using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Users.Commands.UpdateUser
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
            var user = new User(command.FirstName, command.LastName, command.Email, command.Password, command.UserType);
            _repository.UpdateUser(user);
            return Task.FromResult(user.Id);
        }
    }
}
