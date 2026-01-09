using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ArticleUpdateDto
    {
        [Required(ErrorMessage = "The title is required.")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 characters.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "The content is required.")]
        public string Content { get; set; } = null!;

        [Required(ErrorMessage = "The premium status is required.")]
        public bool IsPremium { get; set; }

        [StringLength(500, ErrorMessage = "The title cannot be longer than 50 characters.")]
        public string? Description { get; set; }

        public string? CoverImageUrl { get; set; }

        public List<int> CategoryIds { get; set; } = new List<int>();

        public override bool Equals(object? obj)
        {
            return obj is ArticleUpdateDto dto &&
                   Title == dto.Title &&
                   Content == dto.Content &&
                   IsPremium == dto.IsPremium &&
                   EqualityComparer<List<int>>.Default.Equals(CategoryIds, dto.CategoryIds);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Content, IsPremium, CategoryIds);
        }
    }
}
