namespace Astralis.Shared.DTOs.Asteroid
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
    }
}
