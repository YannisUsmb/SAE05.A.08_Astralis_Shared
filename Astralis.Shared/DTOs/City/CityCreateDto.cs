using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CityCreateDto
    {
        [Required(ErrorMessage = "The country ID is required.")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [StringLength(100, ErrorMessage = "The name cannot be longer than 100 caracters.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "The postcode is required.")]
        [StringLength(20, ErrorMessage = "The postcode cannot be longer than 20 caracters.")]
        public string PostCode { get; set; } = null!;

        [Required(ErrorMessage = "The latitude is required.")]
        public decimal Latitude { get; set; }

        [Required(ErrorMessage = "The longitude is required.")]
        public decimal Longitude { get; set; }
    }
}
