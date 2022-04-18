using System.ComponentModel.DataAnnotations;

namespace TravelerGuideApp.API.DTOs
{
    public class TravelItineraryPutPostDto
    {
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
    }
}
