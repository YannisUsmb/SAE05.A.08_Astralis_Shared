
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
        public string PlanetTypeDescription { get; set; } = null!;

        public int DetectionMethodId { get; set; }
        public string DetectionMethodName { get; set; } = null!;

        // Scientific Properties (Mixed types)
        public decimal? Distance { get; set; }
        public int? DiscoveryYear { get; set; }
        public decimal? Mass { get; set; }
        public decimal? Radius { get; set; }

        public string? Temperature { get; set; }
        public string? OrbitalPeriod { get; set; }

        public decimal? Eccentricity { get; set; }
        public decimal? StellarMagnitude { get; set; }

        public string? HostStarTemperature { get; set; }
        public string? HostStarMass { get; set; }
        public string? Remark { get; set; }

        // Statistics.
        public int SatelliteCount { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is PlanetDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   PlanetTypeId == dto.PlanetTypeId &&
                   PlanetTypeName == dto.PlanetTypeName &&
                   DetectionMethodId == dto.DetectionMethodId &&
                   DetectionMethodName == dto.DetectionMethodName &&
                   Distance == dto.Distance &&
                   DiscoveryYear == dto.DiscoveryYear &&
                   Mass == dto.Mass &&
                   Radius == dto.Radius &&
                   Temperature == dto.Temperature &&
                   OrbitalPeriod == dto.OrbitalPeriod &&
                   Eccentricity == dto.Eccentricity &&
                   StellarMagnitude == dto.StellarMagnitude &&
                   HostStarTemperature == dto.HostStarTemperature &&
                   HostStarMass == dto.HostStarMass &&
                   Remark == dto.Remark &&
                   SatelliteCount == dto.SatelliteCount;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(PlanetTypeId);
            hash.Add(PlanetTypeName);
            hash.Add(DetectionMethodId);
            hash.Add(DetectionMethodName);
            hash.Add(Distance);
            hash.Add(DiscoveryYear);
            hash.Add(Mass);
            hash.Add(Radius);
            hash.Add(Temperature);
            hash.Add(OrbitalPeriod);
            hash.Add(Eccentricity);
            hash.Add(StellarMagnitude);
            hash.Add(HostStarTemperature);
            hash.Add(HostStarMass);
            hash.Add(Remark);
            hash.Add(SatelliteCount);
            return hash.ToHashCode();
        }
    }
}