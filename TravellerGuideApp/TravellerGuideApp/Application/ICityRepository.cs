using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application
{
    public interface ICityRepository
    {
        void CreateCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int cityId);
        City GetCityById(int cityId);
        IEnumerable<City> GetCities();
    }
}
