namespace Astralis.Shared.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }
        public string? Link { get; set; }

        // Event Type Flattening.
        public int EventTypeId { get; set; }
        public string EventTypeLabel { get; set; } = null!; // Ex: "Concert", "Workshop"

        public int UserId { get; set; }

        // Calculated Property EventInterests.Count()
        public int InterestCount { get; set; }
    }
}
