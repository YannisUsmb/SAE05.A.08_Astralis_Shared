
namespace Astralis.Shared.DTOs
{
    public class CelestialBodyFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? CelestialBodyTypeIds { get; set; }
        public bool? IsDiscovery { get; set; }
        public int? SubtypeId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CelestialBodyFilterDto dto &&
                   SearchText == dto.SearchText &&
                   EqualityComparer<List<int>?>.Default.Equals(CelestialBodyTypeIds, dto.CelestialBodyTypeIds) &&
                   IsDiscovery == dto.IsDiscovery;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchText, CelestialBodyTypeIds, IsDiscovery);
        }
    }
}