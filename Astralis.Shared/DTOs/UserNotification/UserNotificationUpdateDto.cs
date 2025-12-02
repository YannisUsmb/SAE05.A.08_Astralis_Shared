using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserNotificationUpdateDto
    {
        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The notification ID is required.")]
        public int NotificationId { get; set; }

        [Required(ErrorMessage = "The read status is required.")]
        public bool IsRead { get; set; }
    }
}
