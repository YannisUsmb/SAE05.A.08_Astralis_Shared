using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryUpdateDto
    {
        [Required(ErrorMessage = "The title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryUpdateDto dto &&
                   Title == dto.Title;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title);
        }
    }
}
