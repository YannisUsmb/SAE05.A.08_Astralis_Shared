namespace Astralis.Shared.DTOs
{
    public class EventFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? EventTypeIds { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxStartDate { get; set; }
        public DateTime? MinEndDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
    }
}