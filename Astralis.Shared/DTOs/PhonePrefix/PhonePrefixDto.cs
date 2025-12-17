
namespace Astralis.Shared.DTOs
{
    public class PhonePrefixDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? CountryName { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is PhonePrefixDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label);
        }
    }
}
