using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EF_Core.Entity_Configurations
{
    public class TravelItineraryEntityTypeConfiguration : IEntityTypeConfiguration<TravelItinerary>
    {
        public void Configure(EntityTypeBuilder<TravelItinerary> travelItineraryConfiguration)
        {
            travelItineraryConfiguration.HasMany(travel => travel.Locations)
                .WithMany(location => location.TravelItineraries)
                .UsingEntity<ItineraryLocation>(il =>
                        il.HasOne(l => l.Location).WithMany().HasForeignKey(l => l.LocationID),
                    il => il.HasOne(ti => ti.TravelItinerary).WithMany().HasForeignKey(ti => ti.ItineraryID)
                );
            travelItineraryConfiguration.HasOne(travel => travel.User)
                .WithMany(user => user.TravelItineraries)
                .HasForeignKey(travel => travel.UserID);
        }
    }
}