
namespace Astralis.Shared.DTOs
{
    public class MailboxDto
    {
        public List<UserNotificationDto> Notifications { get; set; } = new();

        // Calculated Properties, not mapped to database.
        public int TotalItemsCount => Notifications.Count;

        public override bool Equals(object? obj)
        {
            return obj is MailboxDto dto &&
                   EqualityComparer<List<UserNotificationDto>>.Default.Equals(Notifications, dto.Notifications) &&
                   TotalItemsCount == dto.TotalItemsCount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Notifications, TotalItemsCount);
        }
    }
}
