using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ArticleUpdateDto
    {
        [Required(ErrorMessage = "The article ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is required.")]
        [StringLength(50, ErrorMessage = "The title cannot be longer than 50 characters.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "The content is required.")]
        public string Content { get; set; } = null!;

        [Required(ErrorMessage = "The premium status is required.")]
        public bool IsPremium { get; set; }

        public List<int> CategoryIds { get; set; } = new List<int>();
    }
}
