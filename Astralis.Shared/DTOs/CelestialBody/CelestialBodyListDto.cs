
namespace Astralis.Shared.DTOs
{
    public class CelestialBodyListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Celestial Body Type Info.
        public int CelestialBodyTypeId { get; set; }
        public string CelestialBodyTypeName { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is CelestialBodyListDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   CelestialBodyTypeId == dto.CelestialBodyTypeId &&
                   CelestialBodyTypeName == dto.CelestialBodyTypeName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Alias, CelestialBodyTypeId, CelestialBodyTypeName);
        }
    }
}
