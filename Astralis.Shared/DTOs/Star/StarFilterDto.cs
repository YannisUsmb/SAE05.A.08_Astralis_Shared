
namespace Astralis.Shared.DTOs
{
    public class StarFilterDto
    {
        public string? Name { get; set; }
        public List<int>? SpectralClassIds { get; set; }

        public string? Constellation { get; set; }
        public string? Designation { get; set; }
        public string? BayerDesignation { get; set; }

        public decimal? MinDistance { get; set; }
        public decimal? MaxDistance { get; set; }

        public decimal? MinLuminosity { get; set; }
        public decimal? MaxLuminosity { get; set; }

        public decimal? MinRadius { get; set; }
        public decimal? MaxRadius { get; set; }

        public decimal? MinTemperature { get; set; }
        public decimal? MaxTemperature { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is StarFilterDto dto &&
                   Name == dto.Name &&
                   EqualityComparer<List<int>?>.Default.Equals(SpectralClassIds, dto.SpectralClassIds) &&
                   Constellation == dto.Constellation &&
                   Designation == dto.Designation &&
                   BayerDesignation == dto.BayerDesignation &&
                   MinDistance == dto.MinDistance &&
                   MaxDistance == dto.MaxDistance &&
                   MinLuminosity == dto.MinLuminosity &&
                   MaxLuminosity == dto.MaxLuminosity &&
                   MinRadius == dto.MinRadius &&
                   MaxRadius == dto.MaxRadius &&
                   MinTemperature == dto.MinTemperature &&
                   MaxTemperature == dto.MaxTemperature;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Name);
            hash.Add(SpectralClassIds);
            hash.Add(Constellation);
            hash.Add(Designation);
            hash.Add(BayerDesignation);
            hash.Add(MinDistance);
            hash.Add(MaxDistance);
            hash.Add(MinLuminosity);
            hash.Add(MaxLuminosity);
            hash.Add(MinRadius);
            hash.Add(MaxRadius);
            hash.Add(MinTemperature);
            hash.Add(MaxTemperature);
            return hash.ToHashCode();
        }
    }
}