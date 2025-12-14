using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CelestialBodyUpdateDto
    {
        [Required(ErrorMessage = "The name is required.")]
        [StringLength(100, ErrorMessage = "The name cannot be longer than 100 characters.")]
        public string Name { get; set; } = null!;

        [StringLength(100, ErrorMessage = "The alias cannot be longer than 100 characters.")]
        public string? Alias { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CelestialBodyUpdateDto dto &&
                   Name == dto.Name &&
                   Alias == dto.Alias;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Alias);
        }
    }
}
