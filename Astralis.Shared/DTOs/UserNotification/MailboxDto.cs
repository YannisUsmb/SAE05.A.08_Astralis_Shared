namespace Astralis.Shared.DTOs
{
    public class MailboxDto
    {
        public List<UserNotificationDto> Notifications { get; set; } = new();

        // Calculated Properties, not mapped to database.
        public int TotalItemsCount => Notifications.Count;
    }
}
