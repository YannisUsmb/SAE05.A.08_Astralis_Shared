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

        // Category Info.
        [Required(ErrorMessage = "The product category ID is required.")]
        public int ProductCategoryId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ProductCreateDto dto &&
                   Label == dto.Label &&
                   Description == dto.Description &&
                   Price == dto.Price &&
                   ProductCategoryId == dto.ProductCategoryId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Label, Description, Price, ProductCategoryId);
        }

        // No UserId here; it's set from the authenticated user context (JWT Token).
    }
}
