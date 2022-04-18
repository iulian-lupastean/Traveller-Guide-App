using System.ComponentModel.DataAnnotations;

namespace TravelerGuideApp.API.DTOs
{
    public class CityPutPostDto
    {
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Country { get; set; }
    }
}
