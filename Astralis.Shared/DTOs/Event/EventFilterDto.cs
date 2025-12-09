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

        public override bool Equals(object? obj)
        {
            return obj is EventFilterDto dto &&
                   SearchText == dto.SearchText &&
                   EqualityComparer<List<int>?>.Default.Equals(EventTypeIds, dto.EventTypeIds) &&
                   MinStartDate == dto.MinStartDate &&
                   MaxStartDate == dto.MaxStartDate &&
                   MinEndDate == dto.MinEndDate &&
                   MaxEndDate == dto.MaxEndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchText, EventTypeIds, MinStartDate, MaxStartDate, MinEndDate, MaxEndDate);
        }
    }
}