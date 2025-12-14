namespace Astralis.Shared.DTOs
{
    public class CelestialBodyFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? CelestialBodyTypeIds { get; set; }
        public bool? IsDiscovery { get; set; }
        public int? SubtypeId { get; set; }
    }
}