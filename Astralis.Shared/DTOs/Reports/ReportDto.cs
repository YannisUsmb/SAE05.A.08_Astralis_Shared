namespace Astralis.Shared.DTOs
{
    public class ReportDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }

        // Signaled comment.
        public int CommentId { get; set; }

        // Context of the report.
        public int ReportMotiveId { get; set; }
        public string ReportMotiveLabel { get; set; } = null!; // Ex: "Spam", "Harassment"

        public int ReportStatusId { get; set; }
        public string ReportStatusLabel { get; set; } = null!; // Ex: "Pending", "Resolved"

        // Actors involved.
        public int UserId { get; set; }
        public string UserName { get; set; } = null!; // The one who reported.

        public int? AdminId { get; set; }
        public string? AdminName { get; set; } // The one who handled the report, if any.
    }
}
