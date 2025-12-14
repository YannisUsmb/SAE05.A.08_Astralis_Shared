
namespace Astralis.Shared.DTOs
{
    public class AudioDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string CelestialBodyTypeLabel { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is AudioDto dto &&
                   Id == dto.Id &&
                   Title == dto.Title &&
                   Description == dto.Description &&
                   FilePath == dto.FilePath &&
                   CelestialBodyTypeLabel == dto.CelestialBodyTypeLabel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Description, FilePath, CelestialBodyTypeLabel);
        }
    }
}
