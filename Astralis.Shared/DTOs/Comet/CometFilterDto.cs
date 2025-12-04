namespace Astralis.Shared.DTOs
{
    public class CometFilterDto
    {
        public string? Reference { get; set; }

        public decimal? MinEccentricity { get; set; }
        public decimal? MaxEccentricity { get; set; }

        public decimal? MinInclination { get; set; }
        public decimal? MaxInclination { get; set; }

        public decimal? MinPerihelionAU { get; set; }
        public decimal? MaxPerihelionAU { get; set; }

        public decimal? MinAphelionAU { get; set; }
        public decimal? MaxAphelionAU { get; set; }

        public decimal? MinOrbitalPeriod { get; set; }
        public decimal? MaxOrbitalPeriod { get; set; }

        public decimal? MinMOID { get; set; }
        public decimal? MaxMOID { get; set; }
    }
}