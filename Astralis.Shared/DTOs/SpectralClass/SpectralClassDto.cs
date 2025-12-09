
namespace Astralis.Shared.DTOs
{
    public class SpectralClassDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string Description { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is SpectralClassDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label &&
                   Description == dto.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label, Description);
        }
    }
}
