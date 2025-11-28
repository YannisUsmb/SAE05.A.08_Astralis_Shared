namespace Astralis.Shared.DTOs
{
    public class CommandListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string CommandStatusLabel { get; set; } = null!;
        public int CountItems { get; set; }
    }
}
