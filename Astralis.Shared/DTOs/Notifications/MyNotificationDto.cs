namespace Astralis.Shared.DTOs
{
    public class MyNotificationDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }

        // Additional properties for NotificationDto from UserNotification relation.
        public bool IsRead { get; set; }
        public DateTime ReceivedAt { get; set; }
    }
}
