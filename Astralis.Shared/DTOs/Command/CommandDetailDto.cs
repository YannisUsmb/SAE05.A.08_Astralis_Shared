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
    }
}
