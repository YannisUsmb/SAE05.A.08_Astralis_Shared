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
    }
}
