using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class TravelItinerary
{
    public TravelItinerary(string name, string status, DateTime travelDate)
    {
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        Status = status ?? throw new ArgumentNullException(nameof(Status));
        Travel_Date = travelDate;
    }
    public TravelItinerary()
    {

    }
    public int ID { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(50)]
    [Required]
    public string Status { get; set; }
    [MaxLength(50)]
    [Required]
    public DateTime Travel_Date { get; set; }
    public int UserID { get; set; }
    public int LocationID { get; set; }
    public User User { get; set; } = null;
    public List<Location> Locations { get; set; }
}
