using MediatR;

namespace TravelerGuideApp.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, int>
    {
        private readonly IUserRepository _repository;

        public DeleteUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Handle(DeleteUserCommand query, CancellationToken cancellationToken)
        {
            _repository.Delete(query.Id);
            return Task.FromResult(query.Id);
        }
    }
}
