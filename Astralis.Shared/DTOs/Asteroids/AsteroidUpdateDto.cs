using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class AsteroidUpdateDto
    {
        [Required(ErrorMessage = "The orbital class ID is required.")]
        public int OrbitalClassId { get; set; }

        [StringLength(20, ErrorMessage = "The reference cannot be longer than 20 characters.")]
        public string? Reference { get; set; }

        public decimal? AbsoluteMagnitude { get; set; }
        public decimal? DiameterMinKm { get; set; }
        public decimal? DiameterMaxKm { get; set; }
        public bool? IsPotentiallyHazardous { get; set; }

        public DateTime? OrbitDeterminationDate { get; set; }
        public DateTime? LastObservationDate { get; set; }

        public decimal? SemiMajorAxis { get; set; }
        public decimal? Inclination { get; set; }
    }
}
