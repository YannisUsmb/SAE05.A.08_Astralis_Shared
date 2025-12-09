namespace Astralis.Shared.DTOs
{
    public class CommandDetailDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        // Command status details.
        public int CommandStatusId { get; set; }
        public string CommandStatusLabel { get; set; } = null!; // e.g., "Pending", "Shipped", etc.

        // Collection of order details associated with this command.
        public ICollection<OrderDetailDto> OrderDetails { get; set; } = new List<OrderDetailDto>();

        public override bool Equals(object? obj)
        {
            return obj is CommandDetailDto dto &&
                   Id == dto.Id &&
                   Date == dto.Date &&
                   Total == dto.Total &&
                   CommandStatusId == dto.CommandStatusId &&
                   CommandStatusLabel == dto.CommandStatusLabel &&
                   EqualityComparer<ICollection<OrderDetailDto>>.Default.Equals(OrderDetails, dto.OrderDetails);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Date, Total, CommandStatusId, CommandStatusLabel, OrderDetails);
        }
    }
}
