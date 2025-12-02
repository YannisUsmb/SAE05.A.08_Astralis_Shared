using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserNotificationCreateDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }

        [Required(ErrorMessage = "The read status is required.")]
        public bool IsRead { get; set; }

        [Required(ErrorMessage = "The receiving date is required.")]
        public DateTime ReceivedAt { get; set; }
    }
}
