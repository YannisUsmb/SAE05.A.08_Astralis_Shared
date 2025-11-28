using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryCreateDto
    {
        [Required(ErrorMessage = "The celestial body ID is required.")]
        public int CelestialBodyId { get; set; }

        [Required(ErrorMessage = "The title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;
    }
}
