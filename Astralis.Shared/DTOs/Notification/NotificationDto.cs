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
    }
}
