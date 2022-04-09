using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Infrastructure.Database.EF_Core.Entity_Configurations
{
    public class TravelItineraryEntityTypeConfiguration : IEntityTypeConfiguration<TravelItinerary>
    {
        public void Configure(EntityTypeBuilder<TravelItinerary> travelItineraryConfiguration)
        {
            travelItineraryConfiguration.HasKey(travel => travel.Id);
            travelItineraryConfiguration.HasMany(travel => travel.Locations)
                .WithMany(location => location.TravelItineraries)
                .UsingEntity<ItineraryLocation>(il =>
                        il.HasOne(l => l.Location).WithMany().HasForeignKey(l => l.LocationId),
                    il => il.HasOne(ti => ti.TravelItinerary).WithMany().HasForeignKey(ti => ti.TravelItineraryId)
                );
            travelItineraryConfiguration.HasOne(travel => travel.User)
                .WithMany(user => user.TravelItineraries)
                .HasForeignKey(travel => travel.UserId);
        }
    }
}