namespace Astralis.Shared.DTOs
{
    public class PlanetFilterDto
    {
        public string? Name { get; set; }
        public List<int>? PlanetTypeIds { get; set; }
        public List<int>? DetectionMethodIds { get; set; }
        public decimal? MinDistance { get; set; }
        public decimal? MaxDistance { get; set; }
        public decimal? MinMass { get; set; }
        public decimal? MaxMass { get; set; }
        public decimal? MinRadius { get; set; }
        public decimal? MaxRadius { get; set; }
        public int? MinDiscoveryYear { get; set; }
        public int? MaxDiscoveryYear { get; set; }
        public decimal? MinEccentricity { get; set; }
        public decimal? MaxEccentricity { get; set; }
        public decimal? MinStellarMagnitude { get; set; }
        public decimal? MaxStellarMagnitude { get; set; }
    }
}
