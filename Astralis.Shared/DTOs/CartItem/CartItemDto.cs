
namespace Astralis.Shared.DTOs
{
    public class CartItemDto
    {
        // Cart Item details.
        public int Quantity { get; set; }

        // Product details.
        public int ProductId { get; set; }
        public string ProductLabel { get; set; } = null!;
        public decimal UnitPrice { get; set; }

        // Calculated Property, not mapped to database.
        public decimal TotalPrice => Quantity * UnitPrice;

        public override bool Equals(object? obj)
        {
            return obj is CartItemDto dto &&
                   Quantity == dto.Quantity &&
                   ProductId == dto.ProductId &&
                   ProductLabel == dto.ProductLabel &&
                   UnitPrice == dto.UnitPrice &&
                   TotalPrice == dto.TotalPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity, ProductId, ProductLabel, UnitPrice, TotalPrice);
        }
    }
}
