namespace Astralis.Shared.DTOs
{
    public class PlanetDto
    {
        public int Id { get; set; }

        // Celestial Body Info.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Classification Info.
        public int PlanetTypeId { get; set; }
        public string PlanetTypeName { get; set; } = null!;

        public int DetectionMethodId { get; set; }
        public string DetectionMethodName { get; set; } = null!;

        // Physical & Orbital Characteristics.
        public string? Distance { get; set; }
        public int? DiscoveryYear { get; set; }
        public string? Mass { get; set; }
        public string? Radius { get; set; }
        public string? Temperature { get; set; }

        public decimal? OrbitalPeriod { get; set; }
        public decimal? Eccentricity { get; set; }
        public decimal? StellarMagnitude { get; set; }

        // Host Star Info.
        public string? HostStarTemperature { get; set; }
        public string? HostStarMass { get; set; }
        public string? Remark { get; set; }

        // Statistics.
        public int SatelliteCount { get; set; } // Computed Satellites.Count()
    }
}
