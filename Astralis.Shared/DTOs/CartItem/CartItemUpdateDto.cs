using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CartItemUpdateDto
    {
        // No UserId or ProductId here; those are derived from context and URL.

        [Required(ErrorMessage = "The quantity is required.")]
        [Range(1, 999, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CartItemUpdateDto dto &&
                   Quantity == dto.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity);
        }
    }
}
