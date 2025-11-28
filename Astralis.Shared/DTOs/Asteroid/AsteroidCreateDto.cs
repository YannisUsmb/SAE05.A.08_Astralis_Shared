using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class AsteroidCreateDto : CelestialBodyCreateDto, IValidatableObject
    {
        [Required(ErrorMessage = "The orbital class ID is required.")]
        public int OrbitalClassId { get; set; }

        [StringLength(20, ErrorMessage = "The reference cannot be longer than 20 characters.")]
        public string? Reference { get; set; }

        [Range(-99.99, 99.99, ErrorMessage = "Absolute magnitude must be between -99.99 and 99.99.")]
        public decimal? AbsoluteMagnitude { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Diameter must be positive.")]
        public decimal? DiameterMinKm { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Diameter must be positive.")]
        public decimal? DiameterMaxKm { get; set; }

        public bool? IsPotentiallyHazardous { get; set; }
        public int? OrbitId { get; set; }

        public DateTime? OrbitDeterminationDate { get; set; }
        public DateTime? FirstObservationDate { get; set; }
        public DateTime? LastObservationDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Semi-major axis must be positive.")]
        public decimal? SemiMajorAxis { get; set; }

        [Range(0, 180, ErrorMessage = "Inclination must be between 0 and 180 degrees.")]
        public decimal? Inclination { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Check that DiameterMinKm is not greater than DiameterMaxKm.
            if (DiameterMinKm.HasValue && DiameterMaxKm.HasValue && DiameterMinKm > DiameterMaxKm)
            {
                yield return new ValidationResult(
                    "The minimum diameter cannot be greater than the maximum diameter.",
                    new[] { nameof(DiameterMinKm), nameof(DiameterMaxKm) }
                );
            }

            // Check that LastObservationDate is on or after FirstObservationDate.
            if (FirstObservationDate.HasValue && LastObservationDate.HasValue && LastObservationDate < FirstObservationDate)
            {
                yield return new ValidationResult(
                    "The last observation date must be on or after the first observation date.",
                    new[] { nameof(LastObservationDate), nameof(FirstObservationDate) }
                );
            }
        }
    }
}
