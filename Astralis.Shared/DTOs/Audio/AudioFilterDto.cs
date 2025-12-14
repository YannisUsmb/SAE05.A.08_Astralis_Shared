
namespace Astralis.Shared.DTOs
{
    public class AudioFilterDto
    {
        public string? SearchTerm { get; set; }
        public List<int>? CelestialBodyTypeIds { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AudioFilterDto dto &&
                   SearchTerm == dto.SearchTerm &&
                   EqualityComparer<List<int>?>.Default.Equals(CelestialBodyTypeIds, dto.CelestialBodyTypeIds);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchTerm, CelestialBodyTypeIds);
        }
    }
}