namespace Astralis.Shared.DTOs
{
    public class SatelliteFilterDto
    {
        public string? Name { get; set; }
        public List<int>? PlanetIds { get; set; }

        public decimal? MinGravity { get; set; }
        public decimal? MaxGravity { get; set; }

        public decimal? MinRadius { get; set; }
        public decimal? MaxRadius { get; set; }

        public decimal? MinDensity { get; set; }
        public decimal? MaxDensity { get; set; }
    }
}