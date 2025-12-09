
namespace Astralis.Shared.DTOs
{
    public class AsteroidFilterDto
    {
        public string? Reference { get; set; }
        public List<int>? OrbitalClassIds { get; set; }
        public bool? IsPotentiallyHazardous { get; set; }
        public int? OrbitId { get; set; }

        public decimal? MinAbsoluteMagnitude { get; set; }
        public decimal? MaxAbsoluteMagnitude { get; set; }

        public decimal? MinDiameter { get; set; }
        public decimal? MaxDiameter { get; set; }

        public decimal? MinInclination { get; set; }
        public decimal? MaxInclination { get; set; }

        public decimal? MinSemiMajorAxis { get; set; }
        public decimal? MaxSemiMajorAxis { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AsteroidFilterDto dto &&
                   Reference == dto.Reference &&
                   EqualityComparer<List<int>?>.Default.Equals(OrbitalClassIds, dto.OrbitalClassIds) &&
                   IsPotentiallyHazardous == dto.IsPotentiallyHazardous &&
                   OrbitId == dto.OrbitId &&
                   MinAbsoluteMagnitude == dto.MinAbsoluteMagnitude &&
                   MaxAbsoluteMagnitude == dto.MaxAbsoluteMagnitude &&
                   MinDiameter == dto.MinDiameter &&
                   MaxDiameter == dto.MaxDiameter &&
                   MinInclination == dto.MinInclination &&
                   MaxInclination == dto.MaxInclination &&
                   MinSemiMajorAxis == dto.MinSemiMajorAxis &&
                   MaxSemiMajorAxis == dto.MaxSemiMajorAxis;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Reference);
            hash.Add(OrbitalClassIds);
            hash.Add(IsPotentiallyHazardous);
            hash.Add(OrbitId);
            hash.Add(MinAbsoluteMagnitude);
            hash.Add(MaxAbsoluteMagnitude);
            hash.Add(MinDiameter);
            hash.Add(MaxDiameter);
            hash.Add(MinInclination);
            hash.Add(MaxInclination);
            hash.Add(MinSemiMajorAxis);
            hash.Add(MaxSemiMajorAxis);
            return hash.ToHashCode();
        }
    }
}