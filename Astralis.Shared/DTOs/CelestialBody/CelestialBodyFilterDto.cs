
namespace Astralis.Shared.DTOs
{
    public class CelestialBodyFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? CelestialBodyTypeIds { get; set; }
        public bool? IsDiscovery { get; set; }
        public int? SubtypeId { get; set; }
        
        public string SortBy { get; set; } = "name";
        public bool SortAscending { get; set; } = true;
        
        public PlanetFilterDto? PlanetFilter { get; set; }
        public StarFilterDto? StarFilter { get; set; }
        public AsteroidFilterDto? AsteroidFilter { get; set; }
        public GalaxyQuasarFilterDto? GalaxyFilter { get; set; }
        public CometFilterDto? CometFilter { get; set; }
        public SatelliteFilterDto? SatelliteFilter { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CelestialBodyFilterDto dto &&
                   SearchText == dto.SearchText &&
                   EqualityComparer<List<int>?>.Default.Equals(CelestialBodyTypeIds, dto.CelestialBodyTypeIds) &&
                   IsDiscovery == dto.IsDiscovery &&
                   SubtypeId == dto.SubtypeId && 
                   SortBy == dto.SortBy &&       
                   SortAscending == dto.SortAscending &&
                   EqualityComparer<PlanetFilterDto?>.Default.Equals(PlanetFilter, dto.PlanetFilter) &&
                   EqualityComparer<StarFilterDto?>.Default.Equals(StarFilter, dto.StarFilter) &&
                   EqualityComparer<AsteroidFilterDto?>.Default.Equals(AsteroidFilter, dto.AsteroidFilter) &&
                   EqualityComparer<GalaxyQuasarFilterDto?>.Default.Equals(GalaxyFilter, dto.GalaxyFilter) &&
                   EqualityComparer<CometFilterDto?>.Default.Equals(CometFilter, dto.CometFilter) &&
                   EqualityComparer<SatelliteFilterDto?>.Default.Equals(SatelliteFilter, dto.SatelliteFilter);
        }
        
        public override int GetHashCode()
        {
            var hash = new HashCode();
            
            hash.Add(SearchText);
            hash.Add(CelestialBodyTypeIds);
            hash.Add(IsDiscovery);
            hash.Add(SubtypeId);
            hash.Add(SortBy);
            hash.Add(SortAscending);
            
            hash.Add(PlanetFilter);
            hash.Add(StarFilter);
            hash.Add(AsteroidFilter);
            hash.Add(GalaxyFilter);
            hash.Add(CometFilter);
            hash.Add(SatelliteFilter);
            
            return hash.ToHashCode();
        }
    }
}