using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommentUpdateDto
    {
        [Required(ErrorMessage = "Le texte est requis.")]
        [StringLength(300, ErrorMessage = "Le texte ne peut pas dépasser 300 caractères.")]
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
