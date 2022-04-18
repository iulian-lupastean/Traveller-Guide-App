namespace TravelerGuideApp.API.DTOs
{
    public class UserGetDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public ICollection<TravelItineraryPutPostDto> TravelItineraries { get; set; }
    }
}
