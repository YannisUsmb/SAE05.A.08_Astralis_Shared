
namespace Astralis.Shared.DTOs
{
    public class PlanetFilterDto
    {
        public string? Name { get; set; }
        public List<int>? PlanetTypeIds { get; set; }
        public List<int>? DetectionMethodIds { get; set; }
        public decimal? MinDistance { get; set; }
        public decimal? MaxDistance { get; set; }
        public decimal? MinMass { get; set; }
        public decimal? MaxMass { get; set; }
        public decimal? MinRadius { get; set; }
        public decimal? MaxRadius { get; set; }
        public int? MinDiscoveryYear { get; set; }
        public int? MaxDiscoveryYear { get; set; }
        public decimal? MinEccentricity { get; set; }
        public decimal? MaxEccentricity { get; set; }
        public decimal? MinStellarMagnitude { get; set; }
        public decimal? MaxStellarMagnitude { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is PlanetFilterDto dto &&
                   Name == dto.Name &&
                   EqualityComparer<List<int>?>.Default.Equals(PlanetTypeIds, dto.PlanetTypeIds) &&
                   EqualityComparer<List<int>?>.Default.Equals(DetectionMethodIds, dto.DetectionMethodIds) &&
                   MinDistance == dto.MinDistance &&
                   MaxDistance == dto.MaxDistance &&
                   MinMass == dto.MinMass &&
                   MaxMass == dto.MaxMass &&
                   MinRadius == dto.MinRadius &&
                   MaxRadius == dto.MaxRadius &&
                   MinDiscoveryYear == dto.MinDiscoveryYear &&
                   MaxDiscoveryYear == dto.MaxDiscoveryYear &&
                   MinEccentricity == dto.MinEccentricity &&
                   MaxEccentricity == dto.MaxEccentricity &&
                   MinStellarMagnitude == dto.MinStellarMagnitude &&
                   MaxStellarMagnitude == dto.MaxStellarMagnitude;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Name);
            hash.Add(PlanetTypeIds);
            hash.Add(DetectionMethodIds);
            hash.Add(MinDistance);
            hash.Add(MaxDistance);
            hash.Add(MinMass);
            hash.Add(MaxMass);
            hash.Add(MinRadius);
            hash.Add(MaxRadius);
            hash.Add(MinDiscoveryYear);
            hash.Add(MaxDiscoveryYear);
            hash.Add(MinEccentricity);
            hash.Add(MaxEccentricity);
            hash.Add(MinStellarMagnitude);
            hash.Add(MaxStellarMagnitude);
            return hash.ToHashCode();
        }
    }
}
