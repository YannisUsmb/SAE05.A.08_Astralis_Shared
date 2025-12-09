namespace Astralis.Shared.DTOs
{
    public class AsteroidDto
    {
        public int Id { get; set; }

        // Celestial Body Properties.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Orbital Class Properties.
        public int OrbitalClassId { get; set; }
        public string OrbitalClassName { get; set; } = null!;
        public string OrbitalClassDescription { get; set; } = null!;

        // Scientific Properties.
        public string? Reference { get; set; }
        public bool? IsPotentiallyHazardous { get; set; }

        public decimal? AbsoluteMagnitude { get; set; }
        public decimal? DiameterMinKm { get; set; }
        public decimal? DiameterMaxKm { get; set; }

        public int? OrbitId { get; set; }

        // Dates.
        public DateTime? OrbitDeterminationDate { get; set; }
        public DateTime? FirstObservationDate { get; set; }
        public DateTime? LastObservationDate { get; set; }

        // Orbital Properties.
        public decimal? SemiMajorAxis { get; set; }
        public decimal? Inclination { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AsteroidDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   OrbitalClassId == dto.OrbitalClassId &&
                   OrbitalClassName == dto.OrbitalClassName &&
                   OrbitalClassDescription == dto.OrbitalClassDescription &&
                   Reference == dto.Reference &&
                   IsPotentiallyHazardous == dto.IsPotentiallyHazardous &&
                   AbsoluteMagnitude == dto.AbsoluteMagnitude &&
                   DiameterMinKm == dto.DiameterMinKm &&
                   DiameterMaxKm == dto.DiameterMaxKm &&
                   OrbitId == dto.OrbitId &&
                   OrbitDeterminationDate == dto.OrbitDeterminationDate &&
                   FirstObservationDate == dto.FirstObservationDate &&
                   LastObservationDate == dto.LastObservationDate &&
                   SemiMajorAxis == dto.SemiMajorAxis &&
                   Inclination == dto.Inclination;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(OrbitalClassId);
            hash.Add(OrbitalClassName);
            hash.Add(OrbitalClassDescription);
            hash.Add(Reference);
            hash.Add(IsPotentiallyHazardous);
            hash.Add(AbsoluteMagnitude);
            hash.Add(DiameterMinKm);
            hash.Add(DiameterMaxKm);
            hash.Add(OrbitId);
            hash.Add(OrbitDeterminationDate);
            hash.Add(FirstObservationDate);
            hash.Add(LastObservationDate);
            hash.Add(SemiMajorAxis);
            hash.Add(Inclination);
            return hash.ToHashCode();
        }
    }
}
