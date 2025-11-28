namespace Astralis.Shared.DTOs
{
    public class GalaxyQuasarDto
    {
        public int Id { get; set; }

        // Celestial Body Info.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Class Info.
        public int GalaxyQuasarClassId { get; set; }
        public string GalaxyQuasarClassName { get; set; } = null!;

        // Scientific Data.
        public string? Reference { get; set; }
        public decimal? RightAscension { get; set; }
        public decimal? Declination { get; set; }
        public decimal? Redshift { get; set; }
        public decimal? RMagnitude { get; set; }
        public int? ModifiedJulianDateObservation { get; set; }
    }
}
