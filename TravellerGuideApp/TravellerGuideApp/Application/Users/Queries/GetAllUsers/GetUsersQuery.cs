using MediatR;

namespace TravelerGuideApp.Application.Users.Queries.GetAllUsers
{
    public class GetUsersQuery : IRequest<IEnumerable<UsersListVm>>
    {
    }
}
