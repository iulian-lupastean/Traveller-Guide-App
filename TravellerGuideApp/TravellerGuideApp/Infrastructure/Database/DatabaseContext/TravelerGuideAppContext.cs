using Domain.Entities;
using Infrastructure.Database.EF_Core.Entity_Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.DatabaseContext
{
    public class TravelerGuideDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TravelItinerary> Travels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4NUOG8A;Database=TravelerGuideApp;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LocationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TravelItineraryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CityEntityTypeConfiguration());
        }
    }
}
