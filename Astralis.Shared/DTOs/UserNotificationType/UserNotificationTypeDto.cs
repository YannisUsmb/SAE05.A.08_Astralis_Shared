namespace Astralis.Shared.DTOs
{
    public class UserNotificationTypeDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public bool ByMail { get; set; }
    }
}
