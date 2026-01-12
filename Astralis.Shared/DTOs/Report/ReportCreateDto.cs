using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ReportCreateDto
    {
        [Required(ErrorMessage = "The comment ID is required.")]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un motif.")]
        public int ReportMotiveId { get; set; }

        [MaxLength(500, ErrorMessage = "La description ne peut pas dépasser 500 caractères.")]
        public string? Description { get; set; }

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
