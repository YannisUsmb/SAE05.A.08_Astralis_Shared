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
    }
}
