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
    }
}
