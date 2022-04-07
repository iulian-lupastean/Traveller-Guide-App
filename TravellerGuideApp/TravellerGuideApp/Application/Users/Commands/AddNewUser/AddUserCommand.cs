using MediatR;

namespace Application.Users.Commands.AddNewUser
{
    public class AddUserCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string User_Type { get; set; }
    }
}
