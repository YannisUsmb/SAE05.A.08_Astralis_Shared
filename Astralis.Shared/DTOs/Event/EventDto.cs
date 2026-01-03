namespace Astralis.Shared.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? PictureUrl { get; set; }
        public string? Location { get; set; }
        public string? Link { get; set; }

        // Event Type Flattening.
        public int EventTypeId { get; set; }
        public string EventTypeLabel { get; set; } = null!; // Ex: "Concert", "Workshop"

        public int UserId { get; set; }

        // Calculated Property EventInterests.Count()
        public int InterestCount { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EventDto dto &&
                   Id == dto.Id &&
                   Title == dto.Title &&
                   Description == dto.Description &&
                   StartDate == dto.StartDate &&
                   EndDate == dto.EndDate &&
                   Location == dto.Location &&
                   Link == dto.Link &&
                   EventTypeId == dto.EventTypeId &&
                   EventTypeLabel == dto.EventTypeLabel &&
                   UserId == dto.UserId &&
                   InterestCount == dto.InterestCount;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Title);
            hash.Add(Description);
            hash.Add(StartDate);
            hash.Add(EndDate);
            hash.Add(Location);
            hash.Add(Link);
            hash.Add(EventTypeId);
            hash.Add(EventTypeLabel);
            hash.Add(UserId);
            hash.Add(InterestCount);
            return hash.ToHashCode();
        }
    }
}
