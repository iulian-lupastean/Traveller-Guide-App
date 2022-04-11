using System.ComponentModel.DataAnnotations;

namespace TravelerGuideApp.Domain.Entities;

public class User
{
    public User(string firstName, string lastName, string email, string password, string userType)
    {
        firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        email = email ?? throw new ArgumentNullException(nameof(email));
        password = password ?? throw new ArgumentNullException(nameof(password));
        userType = userType ?? throw new ArgumentNullException(nameof(userType));
    }
    public User()
    {
    }
    public int Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string FirstName { get; set; }
    [MaxLength(50)]
    [Required]
    public string LastName { get; set; }
    [MaxLength(50)]
    [Required]
    public string Email { get; set; }
    [MaxLength(50)]
    [MinLength(10)]
    [Required]
    public string Password { get; set; }
    [MaxLength(50)]
    [MinLength(5)]
    [Required]
    public string UserType { get; set; }
    public List<TravelItinerary> TravelItineraries { get; set; }
}
