using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryGalaxyQuasarSubmissionDto
    {
        [Required(ErrorMessage = "The discovery title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        [Required]
        public GalaxyQuasarCreateDto Details { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryGalaxyQuasarSubmissionDto dto &&
                   Title == dto.Title &&
                   EqualityComparer<GalaxyQuasarCreateDto>.Default.Equals(Details, dto.Details);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Details);
        }
    }
}