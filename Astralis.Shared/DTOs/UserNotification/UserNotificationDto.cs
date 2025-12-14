namespace Astralis.Shared.DTOs
{
    public class UserNotificationDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public bool IsRead { get; set; }
        public DateTime ReceivedAt { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserNotificationDto dto &&
                   UserId == dto.UserId &&
                   NotificationId == dto.NotificationId &&
                   IsRead == dto.IsRead &&
                   ReceivedAt == dto.ReceivedAt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserId, NotificationId, IsRead, ReceivedAt);
        }
    }
}
