using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class SatelliteUpdateDto
    {
        [Required(ErrorMessage = "The satellite ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The planet ID is required.")]
        public int PlanetId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Gravity must be positive.")]
        public decimal? Gravity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Radius must be positive.")]
        public decimal? Radius { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Density must be positive.")]
        public decimal? Density { get; set; }
    }
}
