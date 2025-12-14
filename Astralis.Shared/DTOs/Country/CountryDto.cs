
namespace Astralis.Shared.DTOs
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CountryDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
