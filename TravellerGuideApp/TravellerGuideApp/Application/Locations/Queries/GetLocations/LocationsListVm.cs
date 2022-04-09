namespace TravelerGuideApp.Application.Locations.Queries.GetLocations
{
    public class LocationsListVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LocationType { get; set; }
        public double Price { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
