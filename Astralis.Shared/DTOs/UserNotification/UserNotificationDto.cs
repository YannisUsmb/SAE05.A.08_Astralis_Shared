namespace Astralis.Shared.DTOs
{
    public class UserNotificationDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public bool IsRead { get; set; }
        public DateTime ReceivedAt { get; set; }
    }
}
