using Domain.Entities;
using MediatR;

namespace Application.Cities.Queries.GetCityByID
{
    public class GetCityByIDQueryHandler : IRequestHandler<GetCityByIDQuery, City>
    {
        private readonly ICityRepository _repository;

        public GetCityByIDQueryHandler(ICityRepository repository)
        {
            _repository = repository;
        }

        public Task<City> Handle(GetCityByIDQuery query, CancellationToken cancellationToken)
        {
            var result = _repository.GetCityByID(query.ID);

            return Task.FromResult(result);
        }

    }
}
