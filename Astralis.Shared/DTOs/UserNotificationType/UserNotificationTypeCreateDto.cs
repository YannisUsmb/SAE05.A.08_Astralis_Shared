using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserNotificationTypeCreateDto
    {
        [Required(ErrorMessage = "The notification type ID is required.")]
        public int NotificationTypeId { get; set; }

        [Required(ErrorMessage = "The mail notification status is required.")]
        public bool ByMail { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserNotificationTypeCreateDto dto &&
                   NotificationTypeId == dto.NotificationTypeId &&
                   ByMail == dto.ByMail;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NotificationTypeId, ByMail);
        }
    }
}