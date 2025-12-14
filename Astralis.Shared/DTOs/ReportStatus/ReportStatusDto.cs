
namespace Astralis.Shared.DTOs
{
    public class ReportStatusDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is ReportStatusDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label);
        }
    }
}
