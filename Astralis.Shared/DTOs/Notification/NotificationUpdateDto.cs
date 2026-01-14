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

        [Url(ErrorMessage = "The link must be a valid URL.")]
        public string? Link { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is NotificationUpdateDto dto &&
                   Id == dto.Id &&
                   NotificationTypeId == dto.NotificationTypeId &&
                   Label == dto.Label &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NotificationTypeId, Label, Description);
        }
    }
}
