using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ReportCreateDto
    {
        [Required(ErrorMessage = "The comment ID is required.")]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "The report motive ID is required.")]
        public int ReportMotiveId { get; set; }

        [Required(ErrorMessage = "The description is required.")]
        [StringLength(150, ErrorMessage = "The description cannot be longer than 150 characters.")]
        public string Description { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is ReportCreateDto dto &&
                   CommentId == dto.CommentId &&
                   ReportMotiveId == dto.ReportMotiveId &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CommentId, ReportMotiveId, Description);
        }
    }
}
