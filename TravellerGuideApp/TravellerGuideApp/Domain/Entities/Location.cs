using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class Location
{
    public Location(string name, int cityID, string address, string location_Type, double price, string latitude, string longitude)
    {
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        CityID = cityID;
        Address = address ?? throw new ArgumentNullException(nameof(Address));
        LocationType = location_Type ?? throw new ArgumentNullException(nameof(LocationType));
        Price = price;
        Latitude = latitude ?? throw new ArgumentNullException(nameof(Latitude));
        Longitude = longitude ?? throw new ArgumentNullException(nameof(Longitude));
    }
    public Location()
    {

    }
    public int ID { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(50)]
    [Required]
    public string Address { get; set; }
    [MaxLength(50)]
    [Required]
    public string LocationType { get; set; }
    public double Price { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public City City { get; set; } = null;

    public int CityID { get; set; }
    // public TravelItinerary TravelItinerary { get; set; }
    public List<TravelItinerary> TravelItineraries { get; set; }
    public override string ToString()
    {
        return $"{ID} {Name} {CityID} {Address} {LocationType} {Price}  {Latitude} {Longitude}";
    }

}
