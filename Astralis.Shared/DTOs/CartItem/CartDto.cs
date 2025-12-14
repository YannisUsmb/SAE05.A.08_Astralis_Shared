
namespace Astralis.Shared.DTOs
{
    public class CartDto
    {
        public List<CartItemDto> Items { get; set; } = new();

        // Calculated Properties, not mapped to database.
        public decimal GrandTotal => Items.Sum(i => i.TotalPrice);
        public int TotalItemsCount => Items.Sum(i => i.Quantity);

        public override bool Equals(object? obj)
        {
            return obj is CartDto dto &&
                   EqualityComparer<List<CartItemDto>>.Default.Equals(Items, dto.Items) &&
                   GrandTotal == dto.GrandTotal &&
                   TotalItemsCount == dto.TotalItemsCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Items, GrandTotal, TotalItemsCount);
        }
    }
}
