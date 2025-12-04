namespace Astralis.Shared.DTOs
{
    public class AsteroidFilterDto
    {
        public string? Reference { get; set; }
        public List<int>? OrbitalClassIds { get; set; }
        public bool? IsPotentiallyHazardous { get; set; }
        public int? OrbitId { get; set; }

        public decimal? MinAbsoluteMagnitude { get; set; }
        public decimal? MaxAbsoluteMagnitude { get; set; }

        public decimal? MinDiameter { get; set; }
        public decimal? MaxDiameter { get; set; }

        public decimal? MinInclination { get; set; }
        public decimal? MaxInclination { get; set; }

        public decimal? MinSemiMajorAxis { get; set; }
        public decimal? MaxSemiMajorAxis { get; set; }
    }
}