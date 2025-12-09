namespace Astralis.Shared.DTOs
{
    public class ReportFilterDto
    {
        public int? StatusId { get; set; }
        public int? MotiveId { get; set; }
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ReportFilterDto dto &&
                   StatusId == dto.StatusId &&
                   MotiveId == dto.MotiveId &&
                   MinDate == dto.MinDate &&
                   MaxDate == dto.MaxDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StatusId, MotiveId, MinDate, MaxDate);
        }
    }
}