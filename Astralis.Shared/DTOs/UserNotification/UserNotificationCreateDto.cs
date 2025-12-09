using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserNotificationCreateDto
    {
        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The notification ID is required.")]
        public int NotificationId { get; set; }

        [Required(ErrorMessage = "The read status is required.")]
        public bool IsRead { get; set; }

        [Required(ErrorMessage = "The receiving date is required.")]
        public DateTime ReceivedAt { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserNotificationCreateDto dto &&
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
