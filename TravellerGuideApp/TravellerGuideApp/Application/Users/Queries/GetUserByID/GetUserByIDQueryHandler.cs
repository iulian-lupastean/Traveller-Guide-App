using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Users.Queries.GetUserByID
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _repository;

        public GetUserByIdQueryHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public Task<User> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetUser(query.Id);

            return Task.FromResult(result);
        }
    }
}
