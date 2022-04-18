using MediatR;
using TravelerGuideApp.Domain.Entities;

namespace TravelerGuideApp.Application.Commands
{
    public class UpdateTravelItineraryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime TravelDate { get; set; }
        public int UserId { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
