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
    }
}