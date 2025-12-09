
namespace Astralis.Shared.DTOs
{
    public class CommandStatusDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CommandStatusDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label);
        }
    }
}
