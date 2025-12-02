using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommentUpdateDto
    {
        [Required(ErrorMessage = "The comment ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The text is required.")]
        [StringLength(300, ErrorMessage = "The text cannot be longer than 300 characters.")]
        public string Text { get; set; } = null!;
    }
}
