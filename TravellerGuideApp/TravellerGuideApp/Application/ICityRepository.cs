using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ICityRepository
    {
        void Create(City city);
        void Update(City city);
        void Delete(int cityId);
        City GetById(int cityId);
        IEnumerable<City> GetAll();
    }
}
