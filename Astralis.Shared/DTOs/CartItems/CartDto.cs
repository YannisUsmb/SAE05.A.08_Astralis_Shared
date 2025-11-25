namespace Astralis.Shared.DTOs
{
    public class CartDto
    {
        public List<CartItemDto> Items { get; set; } = new();

        // Calculated Properties, not mapped to database.
        public decimal GrandTotal => Items.Sum(i => i.TotalPrice);
        public int TotalItemsCount => Items.Sum(i => i.Quantity);
    }
}
