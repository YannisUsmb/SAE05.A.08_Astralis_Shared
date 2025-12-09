using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class GalaxyQuasarCreateDto : CelestialBodyCreateDto
    {
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

        public override bool Equals(object? obj)
        {
            return obj is GalaxyQuasarCreateDto dto &&
                   base.Equals(obj) &&
                   CelestialBodyTypeId == dto.CelestialBodyTypeId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   GalaxyQuasarClassId == dto.GalaxyQuasarClassId &&
                   Reference == dto.Reference &&
                   RightAscension == dto.RightAscension &&
                   Declination == dto.Declination &&
                   Redshift == dto.Redshift &&
                   RMagnitude == dto.RMagnitude &&
                   ModifiedJulianDateObservation == dto.ModifiedJulianDateObservation;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(CelestialBodyTypeId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(GalaxyQuasarClassId);
            hash.Add(Reference);
            hash.Add(RightAscension);
            hash.Add(Declination);
            hash.Add(Redshift);
            hash.Add(RMagnitude);
            hash.Add(ModifiedJulianDateObservation);
            return hash.ToHashCode();
        }
    }
}
