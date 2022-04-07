using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EF_Core.Entity_Configurations
{
    public class LocationEntityTypeConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> locationConfiguration)
        {
            locationConfiguration.HasOne(location => location.City)
                .WithMany(city => city.Locations)
                .HasForeignKey(location => location.CityID);
        }
    }
}
