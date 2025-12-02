namespace Astralis.Shared.DTOs
{
    public class PlanetFilterDto
    {
        public string? Name { get; set; }

        // List of Ids for filtering.
        public List<int>? PlanetTypeIds { get; set; }
        public List<int>? DetectionMethodIds { get; set; }

        // Filtres numériques (Ranges)
        public int? MinDiscoveryYear { get; set; }
        public int? MaxDiscoveryYear { get; set; }

        public decimal? MinOrbitalPeriod { get; set; }
        public decimal? MaxOrbitalPeriod { get; set; }

        public decimal? MinEccentricity { get; set; }
        public decimal? MaxEccentricity { get; set; }

        public decimal? MinStellarMagnitude { get; set; }
        public decimal? MaxStellarMagnitude { get; set; }

        // Partial match filters.
        public string? Distance { get; set; }
        public string? Radius { get; set; }
        public string? Temperature { get; set; }
        public string? HostStarTemperature { get; set; }
        public string? HostStarMass { get; set; }
    }
}
