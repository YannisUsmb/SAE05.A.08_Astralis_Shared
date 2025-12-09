
namespace Astralis.Shared.DTOs
{
    public class GalaxyQuasarDto
    {
        public int Id { get; set; }

        // Celestial Body Info.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Class Info.
        public int GalaxyQuasarClassId { get; set; }
        public string GalaxyQuasarClassName { get; set; } = null!;

        // Scientific Data.
        public string? Reference { get; set; }
        public decimal? RightAscension { get; set; }
        public decimal? Declination { get; set; }
        public decimal? Redshift { get; set; }
        public decimal? RMagnitude { get; set; }
        public int? ModifiedJulianDateObservation { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is GalaxyQuasarDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   GalaxyQuasarClassId == dto.GalaxyQuasarClassId &&
                   GalaxyQuasarClassName == dto.GalaxyQuasarClassName &&
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
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(GalaxyQuasarClassId);
            hash.Add(GalaxyQuasarClassName);
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
