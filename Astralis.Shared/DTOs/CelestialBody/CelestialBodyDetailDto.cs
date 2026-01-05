namespace Astralis.Shared.DTOs;

public class CelestialBodyDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Alias { get; set; }
    
    public int CelestialBodyTypeId { get; set; }
    public string CelestialBodyTypeName { get; set; } = null!;
    
    public PlanetDto? Planet { get; set; }
    public StarDto? Star { get; set; }
    public AsteroidDto? Asteroid { get; set; }
    public SatelliteDto? Satellite { get; set; }
    public GalaxyQuasarDto? GalaxyQuasar { get; set; }
    public CometDto? Comet { get; set; }
    
    public DiscoveryDto? Discovery { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is CelestialBodyDetailDto dto &&
               Id == dto.Id &&
               Name == dto.Name &&
               Alias == dto.Alias &&
               CelestialBodyTypeId == dto.CelestialBodyTypeId &&
               CelestialBodyTypeName == dto.CelestialBodyTypeName &&
               EqualityComparer<PlanetDto?>.Default.Equals(Planet, dto.Planet) &&
               EqualityComparer<StarDto?>.Default.Equals(Star, dto.Star) &&
               EqualityComparer<AsteroidDto?>.Default.Equals(Asteroid, dto.Asteroid) &&
               EqualityComparer<SatelliteDto?>.Default.Equals(Satellite, dto.Satellite) &&
               EqualityComparer<GalaxyQuasarDto?>.Default.Equals(GalaxyQuasar, dto.GalaxyQuasar) &&
               EqualityComparer<CometDto?>.Default.Equals(Comet, dto.Comet) &&
               EqualityComparer<DiscoveryDto?>.Default.Equals(Discovery, dto.Discovery);
    }

    public override int GetHashCode()
    {
        HashCode hash = new HashCode();
        hash.Add(Id);
        hash.Add(Name);
        hash.Add(Alias);
        hash.Add(CelestialBodyTypeId);
        hash.Add(CelestialBodyTypeName);
        hash.Add(Planet);
        hash.Add(Star);
        hash.Add(Asteroid);
        hash.Add(Satellite);
        hash.Add(GalaxyQuasar);
        hash.Add(Comet);
        hash.Add(Discovery);
        return hash.ToHashCode();
    }
}