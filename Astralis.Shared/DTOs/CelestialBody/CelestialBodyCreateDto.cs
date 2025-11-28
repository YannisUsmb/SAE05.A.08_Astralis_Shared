using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CelestialBodyCreateDto
    {
        [Required(ErrorMessage = "The celestial body type ID is required.")]
        public int CelestialBodyTypeId { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [StringLength(100, ErrorMessage = "The name cannot be longer than 100 characters.")]
        public string Name { get; set; } = null!;

        [StringLength(100, ErrorMessage = "The alias cannot be longer than 100 characters.")]
        public string? Alias { get; set; }
    }
}
