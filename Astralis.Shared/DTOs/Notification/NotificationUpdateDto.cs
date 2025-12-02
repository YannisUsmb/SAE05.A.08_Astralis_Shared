using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class NotificationUpdateDto
    {
        [Required(ErrorMessage = "The notification ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The notification type ID is required.")]
        public int NotificationTypeId { get; set; }

        [Required(ErrorMessage = "The label is required.")]
        [StringLength(100, ErrorMessage = "The label cannot be longer than 100 characters.")]
        public string Label { get; set; } = null!;

        [StringLength(300, ErrorMessage = "The description cannot be longer than 300 characters.")]
        public string? Description { get; set; }
    }
}
