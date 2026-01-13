using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommentCreateDto
    {
        // User ID will be taken from the authenticated user context.

        [Required(ErrorMessage = "L'ID de l'article est requis.")]
        public int ArticleId { get; set; }

        // If null, the comment is not a reply to another comment
        public int? RepliesToId { get; set; }

        [Required(ErrorMessage = "Le texte est requis.")]
        [StringLength(300, ErrorMessage = "Le texte ne peut pas dépasser 300 caractères.")]
        public string Text { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CommentCreateDto dto &&
                   ArticleId == dto.ArticleId &&
                   RepliesToId == dto.RepliesToId &&
                   Text == dto.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArticleId, RepliesToId, Text);
        }

        // DateCreated will be set by the server.

        // IsVisible is true by default.
    }
}
