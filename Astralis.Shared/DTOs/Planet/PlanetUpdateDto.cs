using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class PlanetUpdateDto : IValidatableObject
    {
        [Required(ErrorMessage = "The planet type ID is required.")]
        public int PlanetTypeId { get; set; }

        [Required(ErrorMessage = "The detection method ID is required.")]
        public int DetectionMethodId { get; set; }

        // Decimal fields
        [Range(0, double.MaxValue, ErrorMessage = "Distance must be positive.")]
        public decimal? Distance { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Mass must be positive.")]
        public decimal? Mass { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Radius must be positive.")]
        public decimal? Radius { get; set; }

        public int? DiscoveryYear { get; set; }

        [Range(0, 1, ErrorMessage = "Eccentricity must be between 0 and 1.")]
        public decimal? Eccentricity { get; set; }

        [Range(-30, 30, ErrorMessage = "Stellar magnitude seems unrealistic.")]
        public decimal? StellarMagnitude { get; set; }

        // String fields
        [StringLength(30, ErrorMessage = "The temperature cannot be longer than 30 characters.")]
        public string? Temperature { get; set; }

        [StringLength(40, ErrorMessage = "The orbital period cannot be longer than 40 characters.")]
        public string? OrbitalPeriod { get; set; }

        [StringLength(30, ErrorMessage = "The host star temperature cannot be longer than 30 characters.")]
        public string? HostStarTemperature { get; set; }

        [StringLength(30, ErrorMessage = "The host star mass cannot be longer than 30 characters.")]
        public string? HostStarMass { get; set; }

        [StringLength(250, ErrorMessage = "The remark cannot be longer than 250 characters.")]
        public string? Remark { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DiscoveryYear.HasValue && DiscoveryYear.Value > DateTime.Now.Year)
            {
                yield return new ValidationResult("Discovery year cannot be in the future.", new[] { nameof(DiscoveryYear) });
            }
        }
    }
}