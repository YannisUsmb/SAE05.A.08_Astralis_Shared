namespace Astralis.Shared.DTOs
{
    public class ReportFilterDto
    {
        public int? StatusId { get; set; }
        public int? MotiveId { get; set; }
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
    }
}