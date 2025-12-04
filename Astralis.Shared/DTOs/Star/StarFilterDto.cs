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
    }
}