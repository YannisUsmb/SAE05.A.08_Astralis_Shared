
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

        public override bool Equals(object? obj)
        {
            return obj is SatelliteFilterDto dto &&
                   Name == dto.Name &&
                   EqualityComparer<List<int>?>.Default.Equals(PlanetIds, dto.PlanetIds) &&
                   MinGravity == dto.MinGravity &&
                   MaxGravity == dto.MaxGravity &&
                   MinRadius == dto.MinRadius &&
                   MaxRadius == dto.MaxRadius &&
                   MinDensity == dto.MinDensity &&
                   MaxDensity == dto.MaxDensity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, PlanetIds, MinGravity, MaxGravity, MinRadius, MaxRadius, MinDensity, MaxDensity);
        }
    }
}