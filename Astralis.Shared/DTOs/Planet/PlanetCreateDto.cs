using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class PlanetCreateDto : CelestialBodyCreateDto, IValidatableObject
    {
        [Required(ErrorMessage = "The planet type ID is required.")]
        public int PlanetTypeId { get; set; }

        [Required(ErrorMessage = "The detection method ID is required.")]
        public int DetectionMethodId { get; set; }

        [StringLength(10, ErrorMessage = "The distance cannot be longer than 10 characters.")]
        public string? Distance { get; set; }

        public int? DiscoveryYear { get; set; }

        [StringLength(20, ErrorMessage = "The mass cannot be longer than 20 characters.")]
        public string? Mass { get; set; }

        [StringLength(10, ErrorMessage = "The radius cannot be longer than 10 characters.")]
        public string? Radius { get; set; }

        [StringLength(15, ErrorMessage = "The temperature cannot be longer than 15 characters.")]
        public string? Temperature { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Orbital period must be positive.")]
        public decimal? OrbitalPeriod { get; set; }

        [Range(0, 1, ErrorMessage = "Eccentricity must be between 0 and 1.")]
        public decimal? Eccentricity { get; set; }

        [Range(-30, 30, ErrorMessage = "Stellar magnitude seems unrealistic.")]
        public decimal? StellarMagnitude { get; set; }

        [StringLength(15, ErrorMessage = "The host star temperature cannot be longer than 15 characters.")]
        public string? HostStarTemperature { get; set; }

        [StringLength(15, ErrorMessage = "The host star mass cannot be longer than 15 characters.")]
        public string? HostStarMass { get; set; }

        [StringLength(250, ErrorMessage = "The remark cannot be longer than 250 characters.")]
        public string? Remark { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Check that DiscoveryYear is not in the future.
            if (DiscoveryYear.HasValue && DiscoveryYear.Value > DateTime.Now.Year)
            {
                yield return new ValidationResult(
                    "Discovery year cannot be in the future.",
                    new[] { nameof(DiscoveryYear) }
                );
            }
        }
    }
}
