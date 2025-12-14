using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryAsteroidSubmissionDto
    {
        [Required(ErrorMessage = "The discovery title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        [Required]
        public AsteroidCreateDto Details { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryAsteroidSubmissionDto dto &&
                   Title == dto.Title &&
                   EqualityComparer<AsteroidCreateDto>.Default.Equals(Details, dto.Details);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Details);
        }
    }
}