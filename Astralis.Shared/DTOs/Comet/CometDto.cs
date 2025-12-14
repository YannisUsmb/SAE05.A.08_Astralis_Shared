
namespace Astralis.Shared.DTOs
{
    public class CometDto
    {
        public int Id { get; set; }

        // Celestial Body Properties.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Scientific Properties.
        public decimal? OrbitalEccentricity { get; set; }
        public decimal? OrbitalInclinationDegrees { get; set; }
        public decimal? AscendingNodeLongitudeDegrees { get; set; }
        public decimal? PerihelionDistanceAU { get; set; }
        public decimal? AphelionDistanceAU { get; set; }
        public decimal? OrbitalPeriodYears { get; set; }
        public decimal? MinimumOrbitIntersectionDistanceAU { get; set; }
        public string? Reference { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CometDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   OrbitalEccentricity == dto.OrbitalEccentricity &&
                   OrbitalInclinationDegrees == dto.OrbitalInclinationDegrees &&
                   AscendingNodeLongitudeDegrees == dto.AscendingNodeLongitudeDegrees &&
                   PerihelionDistanceAU == dto.PerihelionDistanceAU &&
                   AphelionDistanceAU == dto.AphelionDistanceAU &&
                   OrbitalPeriodYears == dto.OrbitalPeriodYears &&
                   MinimumOrbitIntersectionDistanceAU == dto.MinimumOrbitIntersectionDistanceAU &&
                   Reference == dto.Reference;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(OrbitalEccentricity);
            hash.Add(OrbitalInclinationDegrees);
            hash.Add(AscendingNodeLongitudeDegrees);
            hash.Add(PerihelionDistanceAU);
            hash.Add(AphelionDistanceAU);
            hash.Add(OrbitalPeriodYears);
            hash.Add(MinimumOrbitIntersectionDistanceAU);
            hash.Add(Reference);
            return hash.ToHashCode();
        }
    }
}
