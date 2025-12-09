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

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryCreateDto dto &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Title == dto.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CelestialBodyId, Title);
        }
    }
}
