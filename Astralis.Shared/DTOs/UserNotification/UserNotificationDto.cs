namespace Astralis.Shared.DTOs
{
    public class UserNotificationDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public bool ByMail { get; set; }
    }
}
