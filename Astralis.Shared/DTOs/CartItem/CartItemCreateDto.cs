using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CartItemCreateDto
    {
        // User ID will be taken from the authenticated user context.

        [Required(ErrorMessage = "The product ID is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The quantity is required.")]
        [Range(1, 999, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; } = 1;
    }
}
