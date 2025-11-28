using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class StarCreateDto : CelestialBodyCreateDto
    {
        public int? SpectralClassId { get; set; }

        [StringLength(10, ErrorMessage = "The designation cannot be longer than 10 characters.")]
        public string? Designation { get; set; }

        public DateOnly? ApprovalDate { get; set; }

        [StringLength(25, ErrorMessage = "The constellation cannot be longer than 25 characters.")]
        public string? Constellation { get; set; }

        [StringLength(30, ErrorMessage = "The bayer designation cannot be longer than 30 characters.")]
        public string? BayerDesignation { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Distance must be positive.")]
        public decimal? Distance { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Luminosity must be positive.")]
        public decimal? Luminosity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Radius must be positive.")]
        public decimal? Radius { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Temperature must be positive.")]
        public decimal? Temperature { get; set; }
    }
}
