namespace Astralis.Shared.DTOs
{
    public class CelestialBodyListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Alias { get; set; }

        // Celestial Body Type Info.
        public int CelestialBodyTypeId { get; set; }
        public string CelestialBodyTypeName { get; set; } = null!;
    }
}
