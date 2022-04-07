using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public class City
{
    public City(string name, string country)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Country = country ?? throw new ArgumentNullException(nameof(country));
    }
    public City()
    {

    }
    public int ID { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(50)]
    [Required]
    public string Country { get; set; }
    public List<Location> Locations { get; set; }

}
