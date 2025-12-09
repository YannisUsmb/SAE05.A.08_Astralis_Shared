
namespace Astralis.Shared.DTOs
{
    public class ReportMotiveDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ReportMotiveDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label, Description);
        }
    }
}
