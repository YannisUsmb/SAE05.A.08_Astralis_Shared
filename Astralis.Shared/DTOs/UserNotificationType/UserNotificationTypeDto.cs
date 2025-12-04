namespace Astralis.Shared.DTOs
{
    public class UserNotificationTypeDto
    {
        public int UserId { get; set; }
        public int NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; } = null!;
        public string? NotificationTypeDescription { get; set; }
        public bool ByMail { get; set; }
    }
}