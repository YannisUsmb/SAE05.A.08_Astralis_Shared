
namespace Astralis.Shared.DTOs
{
    public class NotificationDto
    {
        public int Id { get; set; }

        // Notification Type Properties.
        public int NotificationTypeId { get; set; }
        public string NotificationTypeName { get; set; } = null!;

        public string Label { get; set; } = null!;
        public string? Description { get; set; }
        public string? Link { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is NotificationDto dto &&
                   Id == dto.Id &&
                   NotificationTypeId == dto.NotificationTypeId &&
                   NotificationTypeName == dto.NotificationTypeName &&
                   Label == dto.Label &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NotificationTypeId, NotificationTypeName, Label, Description);
        }
    }
}
