namespace Astralis.Shared.DTOs
{
    public class StarDto
    {
        public int Id { get; set; }

        // Celestial Body Info.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Classification Info.
        public int? SpectralClassId { get; set; }
        public string? SpectralClassName { get; set; }

        // Scientific Info.
        public string? Designation { get; set; }
        public string? Constellation { get; set; }
        public string? BayerDesignation { get; set; }
        public DateOnly? ApprovalDate { get; set; }

        public decimal? Distance { get; set; }
        public decimal? Luminosity { get; set; }
        public decimal? Radius { get; set; }
        public decimal? Temperature { get; set; }
    }
}
