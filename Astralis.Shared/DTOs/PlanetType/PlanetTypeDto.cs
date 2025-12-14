namespace Astralis.Shared.DTOs
{
    public class PlanetTypeDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string Description { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is PlanetTypeDto dto &&
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
