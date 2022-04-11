using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void Delete(int userId);
        User GetById(int userId);
        IEnumerable<User> GetAll();
    }
}
