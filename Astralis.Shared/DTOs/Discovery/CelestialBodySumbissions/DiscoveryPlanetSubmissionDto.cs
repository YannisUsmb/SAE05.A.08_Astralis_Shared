using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryPlanetSubmissionDto
    {
        [Required(ErrorMessage = "The discovery title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        [Required]
        public PlanetCreateDto Details { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryPlanetSubmissionDto dto &&
                   Title == dto.Title &&
                   EqualityComparer<PlanetCreateDto>.Default.Equals(Details, dto.Details);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Details);
        }
    }
}