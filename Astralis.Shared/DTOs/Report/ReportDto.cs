namespace Astralis.Shared.DTOs
{
    public class ReportDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
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

        public override bool Equals(object? obj)
        {
            return obj is ReportDto dto &&
                   Id == dto.Id &&
                   Description == dto.Description &&
                   Date == dto.Date &&
                   CommentId == dto.CommentId &&
                   ReportMotiveId == dto.ReportMotiveId &&
                   ReportMotiveLabel == dto.ReportMotiveLabel &&
                   ReportStatusId == dto.ReportStatusId &&
                   ReportStatusLabel == dto.ReportStatusLabel &&
                   UserId == dto.UserId &&
                   UserName == dto.UserName &&
                   AdminId == dto.AdminId &&
                   AdminName == dto.AdminName;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Description);
            hash.Add(Date);
            hash.Add(CommentId);
            hash.Add(ReportMotiveId);
            hash.Add(ReportMotiveLabel);
            hash.Add(ReportStatusId);
            hash.Add(ReportStatusLabel);
            hash.Add(UserId);
            hash.Add(UserName);
            hash.Add(AdminId);
            hash.Add(AdminName);
            return hash.ToHashCode();
        }
    }
}
