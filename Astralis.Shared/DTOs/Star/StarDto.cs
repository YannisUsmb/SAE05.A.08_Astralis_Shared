
namespace Astralis.Shared.DTOs
{
    public class StarDto
    {
        public int Id { get; set; }

        // Celestial Body Info.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Classification Info.
        public int? SpectralClassId { get; set; }
        public string? SpectralClassName { get; set; }
        public string SpectralClassDescription { get; set; } = null!;

        // Scientific Info.
        public string? Designation { get; set; }
        public string? Constellation { get; set; }
        public string? BayerDesignation { get; set; }
        public DateOnly? ApprovalDate { get; set; }

        public decimal? Distance { get; set; }
        public decimal? Luminosity { get; set; }
        public decimal? Radius { get; set; }
        public decimal? Temperature { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is StarDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   SpectralClassId == dto.SpectralClassId &&
                   SpectralClassName == dto.SpectralClassName &&
                   Designation == dto.Designation &&
                   Constellation == dto.Constellation &&
                   BayerDesignation == dto.BayerDesignation &&
                   EqualityComparer<DateOnly?>.Default.Equals(ApprovalDate, dto.ApprovalDate) &&
                   Distance == dto.Distance &&
                   Luminosity == dto.Luminosity &&
                   Radius == dto.Radius &&
                   Temperature == dto.Temperature;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(SpectralClassId);
            hash.Add(SpectralClassName);
            hash.Add(Designation);
            hash.Add(Constellation);
            hash.Add(BayerDesignation);
            hash.Add(ApprovalDate);
            hash.Add(Distance);
            hash.Add(Luminosity);
            hash.Add(Radius);
            hash.Add(Temperature);
            return hash.ToHashCode();
        }
    }
}
