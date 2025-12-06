using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryCometSubmissionDto
    {
        [Required(ErrorMessage = "The discovery title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        [Required]
        public CometCreateDto Details { get; set; } = null!;
    }
}