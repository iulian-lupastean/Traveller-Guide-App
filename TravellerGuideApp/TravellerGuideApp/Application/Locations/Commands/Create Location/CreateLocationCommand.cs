
using MediatR;

namespace Application.Locations.Commands.Create_Location
{
    public class CreateLocationCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int CityID { get; set; }
        public string Address { get; set; }
        public string Location_Type { get; set; }
        public double Price { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
