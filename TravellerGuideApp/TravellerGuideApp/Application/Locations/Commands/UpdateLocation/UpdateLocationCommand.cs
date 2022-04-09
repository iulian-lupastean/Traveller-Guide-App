using MediatR;

namespace TravelerGuideApp.Application.Locations.Commands.UpdateLocation
{
    public class UpdateLocationCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string LocationType { get; set; }
        public double Price { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
