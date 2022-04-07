using Domain.Entities;

namespace Application
{
    public interface ICityRepository
    {
        void CreateCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int City_ID);
        City GetCityByID(int City_ID);
        IEnumerable<City> GetCities();
    }
}
