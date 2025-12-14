using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommentUpdateDto
    {
        [Required(ErrorMessage = "The text is required.")]
        [StringLength(300, ErrorMessage = "The text cannot be longer than 300 characters.")]
        public string Text { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CommentUpdateDto dto &&
                   Text == dto.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text);
        }
    }
}
