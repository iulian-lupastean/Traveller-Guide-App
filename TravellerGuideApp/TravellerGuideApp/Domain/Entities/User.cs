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

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string UserType { get; set; }
    public List<TravelItinerary> TravelItineraries { get; set; }
}
