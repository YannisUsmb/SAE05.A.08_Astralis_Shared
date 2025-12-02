using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class GalaxyQuasarUpdateDto
    {
        [Required(ErrorMessage = "The galaxy/quasar ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The galaxy/quasar class ID is required.")]
        public int GalaxyQuasarClassId { get; set; }

        [StringLength(100, ErrorMessage = "The reference cannot be longer than 100 characters.")]
        public string? Reference { get; set; }

        [Range(0, 360, ErrorMessage = "Right Ascension must be between 0 and 360 degrees.")]
        public decimal? RightAscension { get; set; }

        [Range(-90, 90, ErrorMessage = "Declination must be between -90 and 90 degrees.")]
        public decimal? Declination { get; set; }

        [Range(-1, 100, ErrorMessage = "Redshift value is out of realistic bounds.")]
        public decimal? Redshift { get; set; }

        [Range(-30, 30, ErrorMessage = "R-Magnitude value seems unrealistic.")]
        public decimal? RMagnitude { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Modified Julian Date must be positive.")]
        public int? ModifiedJulianDateObservation { get; set; }
    }
}
