using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User GetUser(int userId);
        IEnumerable<User> GetAllUsers();
    }
}
