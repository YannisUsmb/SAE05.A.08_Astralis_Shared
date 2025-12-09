
namespace Astralis.Shared.DTOs
{
    public class GalaxyQuasarFilterDto
    {
        public string? Reference { get; set; }
        public List<int>? GalaxyQuasarClassIds { get; set; }

        public decimal? MinRightAscension { get; set; }
        public decimal? MaxRightAscension { get; set; }

        public decimal? MinDeclination { get; set; }
        public decimal? MaxDeclination { get; set; }

        public decimal? MinRedshift { get; set; }
        public decimal? MaxRedshift { get; set; }

        public decimal? MinRMagnitude { get; set; }
        public decimal? MaxRMagnitude { get; set; }

        public int? MinMjdObs { get; set; }
        public int? MaxMjdObs { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is GalaxyQuasarFilterDto dto &&
                   Reference == dto.Reference &&
                   EqualityComparer<List<int>?>.Default.Equals(GalaxyQuasarClassIds, dto.GalaxyQuasarClassIds) &&
                   MinRightAscension == dto.MinRightAscension &&
                   MaxRightAscension == dto.MaxRightAscension &&
                   MinDeclination == dto.MinDeclination &&
                   MaxDeclination == dto.MaxDeclination &&
                   MinRedshift == dto.MinRedshift &&
                   MaxRedshift == dto.MaxRedshift &&
                   MinRMagnitude == dto.MinRMagnitude &&
                   MaxRMagnitude == dto.MaxRMagnitude &&
                   MinMjdObs == dto.MinMjdObs &&
                   MaxMjdObs == dto.MaxMjdObs;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Reference);
            hash.Add(GalaxyQuasarClassIds);
            hash.Add(MinRightAscension);
            hash.Add(MaxRightAscension);
            hash.Add(MinDeclination);
            hash.Add(MaxDeclination);
            hash.Add(MinRedshift);
            hash.Add(MaxRedshift);
            hash.Add(MinRMagnitude);
            hash.Add(MaxRMagnitude);
            hash.Add(MinMjdObs);
            hash.Add(MaxMjdObs);
            return hash.ToHashCode();
        }
    }
}