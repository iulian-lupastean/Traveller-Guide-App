using System;
using System.Globalization;
using TravelerGuideApp.Domain.Entities;
using TravelerGuideApp.Infrastructure.Database.DatabaseContext;

namespace TravelerGuideApp.IntegrationTests.Helpers
{
    public static class Utilities
    {
        public static void InitializeDbForTests(TravelerGuideAppDBContext db)
        {
            var city1 = new City("Madrid", "Spain");
            var city2 = new City("Paris", "France");
            db.Cities.AddRange(city1, city2);
            db.SaveChanges();
            var location1 = new Location(1, "Muzeu1-Madrid", "Adresa1Madrid", "Museum", 15.99, "1", "1");
            var location2 = new Location(1, "Muzeu2-Madrid", "AdresaMuzeu2Madrid", "Museum", 12, "1", "1");
            var location3 = new Location(1, "Park1-Madrid", "AdresaPark1Madrid", "Park", 0, "1", "1");
            var location4 = new Location(2, "Muzeu1-Paris", "Adresa1Madrid", "Museum", 19.99, "1", "1");
            var location5 = new Location(2, "CasaMemoriala1-Paris", "AdresaCasaMemoriala1Paris", "Memorial House", 10, "1", "1");
            var location6 = new Location(2, "Park1-Paris", "AdresaPark1Paris", "Park", 0, "1", "1");
            db.Locations.AddRange(location1, location2, location3, location4, location5, location6);
            db.SaveChanges();

            var user1 = new User("Ion", "Popescu", "ion.popescu@yahoo.com", "12345", "Visitor");
            var user2 = new User("Iulian", "Lupastean", "ilupastean@yahoo.com", "54321", "Administrator");
            var user3 = new User("George", "Enescu", "george.enescu@yahoo.com", "password1", "Visitor");
            db.Users.AddRange(user1, user2, user3);
            db.SaveChanges();
            var travel1 = new TravelItinerary("Travel1-Madrid", "Completed",
                DateTime.Parse("12 June 2021", CultureInfo.GetCultureInfo("ro-RO")),
                1);
            var travel2 = new TravelItinerary("Travel1-Paris", "Planned",
                DateTime.Parse("12 August 2022", CultureInfo.GetCultureInfo("ro-RO")),
                3);
            var travel3 = new TravelItinerary("Travel2-Madrid", "Canceled", DateTime.Parse("12 August 2021", CultureInfo.GetCultureInfo("ro-RO")), 5);

            db.TravelItineraries.AddRange(travel1, travel2, travel3);
            db.SaveChanges();
            var tl1 = new TravelItineraryLocations(1, 1);
            var tl2 = new TravelItineraryLocations(1, 2);
            var tl3 = new TravelItineraryLocations(2, 4);
            var tl4 = new TravelItineraryLocations(2, 5);
            var tl5 = new TravelItineraryLocations(2, 6);
            var tl6 = new TravelItineraryLocations(3, 2);
            var tl7 = new TravelItineraryLocations(3, 3);
            db.TravelItineraryLocations.AddRange(tl1, tl2, tl3, tl4, tl5, tl6, tl7);
            db.SaveChanges();
        }
    }
}
