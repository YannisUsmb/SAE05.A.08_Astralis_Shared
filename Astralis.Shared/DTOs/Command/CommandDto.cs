namespace Astralis.Shared.DTOs
{
    public class CommandDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        // URL of the PDF invoice.
        public string PdfName { get; set; } = null!;

        // Command status details.
        public int CommandStatusId { get; set; }
        public string CommandStatusLabel { get; set; } = null!; // e.g., "Pending", "Shipped", etc.

        // Collection of order details associated with this command.
        public ICollection<OrderDetailDto> OrderDetails { get; set; } = new List<OrderDetailDto>();
    }
}
