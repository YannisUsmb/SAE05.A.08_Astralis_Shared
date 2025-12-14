using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class SatelliteUpdateDto
    {
        [Required(ErrorMessage = "The planet ID is required.")]
        public int PlanetId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Gravity must be positive.")]
        public decimal? Gravity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Radius must be positive.")]
        public decimal? Radius { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Density must be positive.")]
        public decimal? Density { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is SatelliteUpdateDto dto &&
                   PlanetId == dto.PlanetId &&
                   Gravity == dto.Gravity &&
                   Radius == dto.Radius &&
                   Density == dto.Density;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PlanetId, Gravity, Radius, Density);
        }
    }
}
