
namespace Astralis.Shared.DTOs
{
    public class SatelliteDto
    {
        public int Id { get; set; }

        // CelestialBody properties.
        public int CelestialBodyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Host planet information.
        public int PlanetId { get; set; }
        // Include(s => s.PlanetNavigation).ThenInclude(p => p.CelestialBodyNavigation)
        public string PlanetName { get; set; } = null!;

        // Physical characteristics.
        public decimal? Gravity { get; set; }
        public decimal? Radius { get; set; }
        public decimal? Density { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is SatelliteDto dto &&
                   Id == dto.Id &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   Name == dto.Name &&
                   Alias == dto.Alias &&
                   PlanetId == dto.PlanetId &&
                   PlanetName == dto.PlanetName &&
                   Gravity == dto.Gravity &&
                   Radius == dto.Radius &&
                   Density == dto.Density;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(CelestialBodyId);
            hash.Add(Name);
            hash.Add(Alias);
            hash.Add(PlanetId);
            hash.Add(PlanetName);
            hash.Add(Gravity);
            hash.Add(Radius);
            hash.Add(Density);
            return hash.ToHashCode();
        }
    }
}
