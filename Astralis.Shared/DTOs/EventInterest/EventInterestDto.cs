
namespace Astralis.Shared.DTOs
{
    public class EventInterestDto
    {
        public int EventId { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EventInterestDto dto &&
                   EventId == dto.EventId &&
                   UserId == dto.UserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EventId, UserId);
        }
    }
}
