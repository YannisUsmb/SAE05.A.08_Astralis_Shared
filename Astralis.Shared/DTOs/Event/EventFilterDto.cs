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

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortBy { get; set; } = "date_asc";
    }
}