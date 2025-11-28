using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CometUpdateDto : IValidatableObject
    {
        [Range(0, 10, ErrorMessage = "Orbital eccentricity must be between 0 and 10.")]
        public decimal? OrbitalEccentricity { get; set; }

        [Range(0, 180, ErrorMessage = "Inclination must be between 0 and 180 degrees.")]
        public decimal? OrbitalInclinationDegrees { get; set; }

        [Range(0, 360, ErrorMessage = "Longitude must be between 0 and 360 degrees.")]
        public decimal? AscendingNodeLongitudeDegrees { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Perihelion distance must be positive.")]
        public decimal? PerihelionDistanceAU { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Aphelion distance must be positive.")]
        public decimal? AphelionDistanceAU { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Orbital period must be positive.")]
        public decimal? OrbitalPeriodYears { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "MOID must be positive.")]
        public decimal? MinimumOrbitIntersectionDistanceAU { get; set; }

        [StringLength(250, ErrorMessage = "The reference cannot be longer than 250 characters.")]
        public string? Reference { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Valide that PerihelionDistanceAU is not greater than AphelionDistanceAU.
            if (PerihelionDistanceAU.HasValue && AphelionDistanceAU.HasValue
                && PerihelionDistanceAU > AphelionDistanceAU)
            {
                yield return new ValidationResult(
                    "Perihelion distance cannot be greater than Aphelion distance.",
                    new[] { nameof(PerihelionDistanceAU), nameof(AphelionDistanceAU) }
                );
            }
        }
    }
}
