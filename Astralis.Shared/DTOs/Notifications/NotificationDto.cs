namespace Astralis.Shared.DTOs.Notifications
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }
    }
}
