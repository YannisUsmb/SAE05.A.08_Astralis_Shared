using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ReportUpdateDto
    {
        [Required(ErrorMessage = "The report ID is required.")]
        public int Id { get; set; }

        // No need to have admin ID here, it will be taken from the authenticated user context.

        [Required(ErrorMessage = "The report status ID is required.")]
        public int ReportStatusId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ReportUpdateDto dto &&
                   Id == dto.Id &&
                   ReportStatusId == dto.ReportStatusId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ReportStatusId);
        }
    }
}
