using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage = "The label is required.")]
        [StringLength(100, ErrorMessage = "The label cannot be longer than 100 characters.")]
        public string Label { get; set; } = null!;

        [StringLength(300, ErrorMessage = "The description cannot be longer than 300 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "The price is required.")]
        [Range(0.01, 9999.99, ErrorMessage = "Price must be positive.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The product category ID is required.")]
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }
    }
}
