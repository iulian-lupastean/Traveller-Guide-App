using System.ComponentModel.DataAnnotations;

namespace TravelerGuideApp.Domain.Entities;

public class TravelItinerary
{

    public TravelItinerary(string name, string status, DateTime travelDate, int userId)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Status = status ?? throw new ArgumentNullException(nameof(status));
        TravelDate = travelDate;
        UserId = userId;
    }
    public TravelItinerary(int id, string name, string status, DateTime travelDate)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Status = status ?? throw new ArgumentNullException(nameof(status));
        TravelDate = travelDate;
    }
    public TravelItinerary()
    {
    }
    public int Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(30)]
    [Required]
    public string Status { get; set; }
    [MinLength(8)]
    [MaxLength(10)]
    [Required]
    public DateTime TravelDate { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; } = null;
    public ICollection<Location> Locations { get; set; }
}
