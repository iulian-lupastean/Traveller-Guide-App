using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Cities.Queries.GetCityById
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, City>
    {
        private readonly ICityRepository _repository;

        public GetCityByIdQueryHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<City> Handle(GetCityByIdQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetById(query.Id);

            return Task.FromResult(result);
        }

    }
}
