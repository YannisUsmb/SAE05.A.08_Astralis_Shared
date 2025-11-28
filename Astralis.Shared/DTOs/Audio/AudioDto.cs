namespace Astralis.Shared.DTOs
{
    public class AudioDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string CelestialBodyTypeLabel { get; set; } = null!;
    }
}
