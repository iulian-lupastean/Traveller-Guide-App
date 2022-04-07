using Domain.Entities;

namespace Application
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void UpdateUser(int User_ID, User user);
        void DeleteUser(int User_ID);
        User GetUser(int User_ID);
        IEnumerable<User> GetAllUsers();
    }
}
