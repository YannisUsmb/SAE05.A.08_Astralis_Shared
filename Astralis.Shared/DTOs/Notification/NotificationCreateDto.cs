using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class NotificationCreateDto
    {
        [Required(ErrorMessage = "The notification type ID is required.")]
        public int NotificationTypeId { get; set; }

        [Required(ErrorMessage = "The label is required.")]
        [StringLength(100, ErrorMessage = "The label cannot be longer than 100 characters.")]
        public string Label { get; set; } = null!;

        [StringLength(300, ErrorMessage = "The description cannot be longer than 300 characters.")]
        public string? Description { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is NotificationCreateDto dto &&
                   NotificationTypeId == dto.NotificationTypeId &&
                   Label == dto.Label &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NotificationTypeId, Label, Description);
        }
    }
}
