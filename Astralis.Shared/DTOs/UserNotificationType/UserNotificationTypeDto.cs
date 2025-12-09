
namespace Astralis.Shared.DTOs
{
    public class UserNotificationTypeDto
    {
        public int UserId { get; set; }
        public int NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; } = null!;
        public string? NotificationTypeDescription { get; set; }
        public bool ByMail { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserNotificationTypeDto dto &&
                   UserId == dto.UserId &&
                   NotificationTypeId == dto.NotificationTypeId &&
                   NotificationTypeName == dto.NotificationTypeName &&
                   NotificationTypeDescription == dto.NotificationTypeDescription &&
                   ByMail == dto.ByMail;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserId, NotificationTypeId, NotificationTypeName, NotificationTypeDescription, ByMail);
        }
    }
}