using MediatR;

namespace TravelerGuideApp.Application.Users.Queries.GetAllUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<UsersListVm>>
    {
        private readonly IUserRepository _repository;

        public GetUsersQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<UsersListVm>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetAll().Select(user => new UsersListVm
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserType = user.UserType
            });

            return Task.FromResult(result);
        }

    }
}
