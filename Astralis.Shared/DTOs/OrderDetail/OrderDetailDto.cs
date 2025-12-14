
namespace Astralis.Shared.DTOs
{
    public class OrderDetailDto
    {
        // Properties representing order detail information.
        public int CommandId { get; set; }
        public int ProductId { get; set; }
        public string ProductLabel { get; set; } = null!;
        public decimal UnitPrice { get; set; }

        // Quantity of the product ordered.
        public int Quantity { get; set; }

        // Computed property for total line price.
        public decimal TotalLinePrice => Quantity * UnitPrice;

        public override bool Equals(object? obj)
        {
            return obj is OrderDetailDto dto &&
                   CommandId == dto.CommandId &&
                   ProductId == dto.ProductId &&
                   ProductLabel == dto.ProductLabel &&
                   UnitPrice == dto.UnitPrice &&
                   Quantity == dto.Quantity &&
                   TotalLinePrice == dto.TotalLinePrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CommandId, ProductId, ProductLabel, UnitPrice, Quantity, TotalLinePrice);
        }
    }
}
