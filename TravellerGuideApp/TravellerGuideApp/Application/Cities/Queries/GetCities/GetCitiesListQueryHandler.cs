using MediatR;

namespace TravelerGuideApp.Application.Cities.Queries.GetCities
{
    public class GetCitiesListQueryHandler : IRequestHandler<GetCitiesListQuery, IEnumerable<CitiesListVm>>
    {
        private readonly ICityRepository _repository;

        public GetCitiesListQueryHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<CitiesListVm>> Handle(GetCitiesListQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetCities().Select(city => new CitiesListVm
            {
                Id = city.Id,
                Name = city.Name,
                Country = city.Country
            });

            return Task.FromResult(result);
        }

    }
}
