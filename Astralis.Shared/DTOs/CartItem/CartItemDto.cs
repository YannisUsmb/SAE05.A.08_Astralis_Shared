namespace Astralis.Shared.DTOs
{
    public class CartItemDto
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public string ProductLabel { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public string ProductPictureUrl { get; set; } = null!;
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
