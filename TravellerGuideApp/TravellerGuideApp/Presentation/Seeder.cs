using System.Globalization;
using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TravelerGuideApp.Application;
using TravelerGuideApp.Application.Commands;
using TravelerGuideApp.Application.Interfaces;
using TravelerGuideApp.Application.Queries;
using TravelerGuideApp.Domain.Entities;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;
using TravelerGuideApp.Infrastructure.Repositories;

namespace TravelerGuideApp.Presentation
{
    public class Seeder
    {
        public static async Task SeedData()
        {
            var serviceCollection = new ServiceCollection()
                .AddDbContext<TravelerGuideAppDBContext>(options => options.UseSqlServer("Server=DESKTOP-4NUOG8A;Database=TravelerGuideApp;Trusted_Connection=True;"))
                .AddMediatR(typeof(CreateCityCommand))
                .AddScoped<ICityRepository, CityRepository>()
                .AddScoped<ILocationRepository, LocationRepository>()
                .AddScoped<ITravelItineraryRepository, TravelItineraryRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .BuildServiceProvider();

            var _mediator = serviceCollection.GetRequiredService<IMediator>();
            //foreach (var city in GetPreconfiguredCities())
            //{
            //    await _mediator.Send(new CreateCityCommand { Name = city.Name, Country = city.Country });
            //}
            //foreach (var user in GetPreconfiguredUsers())
            //{
            //    await _mediator.Send(new CreateUserCommand
            //    {
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        Email = user.Email,
            //        Password = user.Password,
            //        UserType = user.UserType
            //    });
            //}
            var cities = await _mediator.Send(new GetCitiesListQuery());
            //foreach (var location in GetPreConfiguredLocations())
            //{
            //    location.City = cities.First(x => x.Name.Equals(location.Name.Split('-')[1]));
            //    await _mediator.Send(new CreateLocationCommand
            //    {
            //        Name = location.Name,
            //        Address = location.Address,
            //        LocationType = location.LocationType,
            //        Price = location.Price,
            //        Latitude = location.Latitude,
            //        Longitude = location.Longitude,
            //        CityId = location.City.Id
            //    });
            //}
            //var users = await _mediator.Send(new GetUsersQuery());
            //var locationsInMadrid = await _mediator.Send(new GetLocationsForCityQuery(1));
            //var locationsinParis = await _mediator.Send(new GetLocationsForCityQuery(2));
            //var locationsinLondon = await _mediator.Send(new GetLocationsForCityQuery(3));
            //var locationsinBucuresti = await _mediator.Send(new GetLocationsForCityQuery(4));
            //var locationsinNewYork = await _mediator.Send(new GetLocationsForCityQuery(5));
            //var locationsinBerlin = await _mediator.Send(new GetLocationsForCityQuery(6));


            //foreach (var travel in GetPreconfiguredTravelItineraries())
            //{
            //    await _mediator.Send(new CreateTravelItineraryCommand
            //    {
            //        Name = travel.Name,
            //        Status = travel.Status,
            //        TravelDate = travel.TravelDate,
            //        UserId = travel.UserId
            //    });
            //}
            await _mediator.Send(new CreateLocationCommand
            {
                Name = "Muzeu1-Berlin",
                Address = "AddressMuzeu1-Berlin",
                LocationType = "Museum",
                Price = 13.50,
                Latitude = "1",
                Longitude = "1"
            });
            // await _mediator.Send(new AddLocationToCity{CityId = cities.First(x=>x.Name.Equals("Berlin")).Id,LocationId = });

        }

        private static IEnumerable<City> GetPreconfiguredCities() =>
            new List<City>
            {
                new ("Madrid","Spain"),
                new ("Paris","France"),
                new ("London","United Kingdom"),
                new ("Bucuresti","Romania"),
                new ("New York","USA"),
                new ("Berlin","Germany")
            };

        private static IEnumerable<User> GetPreconfiguredUsers() =>
            new List<User>
            {
                new ("Ion","Popescu","ion.popescu@yahoo.com","12345","Visitor"),
                new("Iulian","Lupastean","ilupastean@yahoo.com","54321","Administrator"),
                new("George","Enescu","george.enescu@yahoo.com","password1","Visitor"),
                new("Maria","Maiorescu","maria.maiorescu@yahoo.com","password2","Visitor"),
                new("Ion","Pop","ion.pop@yahoo.com","password3","Visitor"),
                new("Gina","Popescu","gina.popescu@yahoo.com","password4","Visitor"),
                new("Alexandra","Popa","alexandra.popa@gmail.com","password5","Visitor"),
                new("Ion","Popescu","ion.popescu@yahoo.com","password6","Visitor"),
                new("Ioan","Nascu","ioan.nascu@yahoo.com","Password7","Visitor"),
                new("Elena","Averescu","elena.averescu@yahoo.com","Password7","Visitor")
            };

        private static IEnumerable<Location> GetPreConfiguredLocations() =>
            new List<Location>
            {
                new("Muzeu1-Madrid","Adresa1Madrid","Museum",15.99,"1","1"),
                new("Muzeu2-Madrid","AdresaMuzeu2Madrid","Museum",12,"1","1"),
                new("Park1-Madrid","AdresaPark1Madrid","Park",0,"1","1"),
                new("Muzeu1-Paris","Adresa1Madrid","Museum",19.99,"1","1"),
                new("CasaMemoriala1-Paris","AdresaCasaMemoriala1Paris","Memorial House",10,"1","1"),
                new("Park1-Paris","AdresaPark1Paris","Park",0,"1","1"),
                new("Park1-London","AdresaPark1Londra","Park",0,"1","1"),
                new("Muzeu1-London","AdresaMuzeu1Londra","Museum",18,"1","1"),
                new("Casa1Memoriala1-Bucuresti","AdresaCasaMemoriala1Bucuresti","Memorial House",5,"1","1"),
                new("Muzeu1-Bucuresti","AdresaMuzeu1Bucuresti","Museum",20,"1","1"),
                new("Muzeu1-New York","AdresaMuzeu1NewYork","Museum",22,"1","1"),
                new("CentralPark-New York","AddressCentralParkNewYork","Park",0,"1","1"),
                new("FamousBuilding1-Berlin","AddressFamousBuilding1Berlin","Famous Building",12,"1","1"),
                new("MemorialHouse1-Berlin","AddressMemorialHouse1Berlin","Memorial House",15,"1","1")

            };


        private static IEnumerable<TravelItinerary> GetPreconfiguredTravelItineraries() =>
            new List<TravelItinerary>
            {
                new("Madrid Travel", "Completed",DateTime.Parse("12 June 2021",CultureInfo.GetCultureInfo("ro-RO")),1),
                new("Paris Travel","Planned",DateTime.Parse("12 August 2022",CultureInfo.GetCultureInfo("ro-RO")),3),
                new("Travel to London","Canceled",DateTime.Parse("12 April 2020",CultureInfo.GetCultureInfo("ro-RO")),4),
                new("Bucuresti Travel","Canceled",DateTime.Parse("29 November 2021",CultureInfo.GetCultureInfo("ro-RO")),6),
                new("USA Travel","Completed",DateTime.Parse("19 May 2018",CultureInfo.GetCultureInfo("ro-RO")),8),
                new("Travel to Berlin","Planned",DateTime.Parse("31 July 2022",CultureInfo.GetCultureInfo("ro-RO")),3)
            };
    }
}
