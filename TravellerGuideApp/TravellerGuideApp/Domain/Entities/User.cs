using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    public User(string FirstName, string LastName, string Email, string Password, string User_Type)
    {
        FirstName = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
        LastName = LastName ?? throw new ArgumentNullException(nameof(LastName));
        Email = Email ?? throw new ArgumentNullException(nameof(Email));
        Password = Password ?? throw new ArgumentNullException(nameof(Password));
        User_Type = User_Type ?? throw new ArgumentNullException(nameof(User_Type));
    }
    public User()
    {

    }
    public int ID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string UserType { get; set; }
    public List<TravelItinerary> TravelItineraries { get; set; }
}
