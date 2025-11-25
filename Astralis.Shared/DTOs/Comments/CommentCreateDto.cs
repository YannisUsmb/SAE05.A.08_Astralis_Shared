using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs.Comments
{
    public class CommentCreateDto
    {
        // User ID will be taken from the authenticated user context.

        [Required(ErrorMessage = "The article ID is required.")]
        public int ArticleId { get; set; }

        // If null, the comment is not a reply to another comment
        public int? RepliesToId { get; set; }

        [Required(ErrorMessage = "The text is required.")]
        [StringLength(300, ErrorMessage = "The text cannot be longer than 300 characters.")]
        public string Text { get; set; } = null!;

        // DateCreated will be set by the server.

        // IsVisible is true by default.
    }
}
