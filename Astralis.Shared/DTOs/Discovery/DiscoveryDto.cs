namespace Astralis.Shared.DTOs
{
    public class DiscoveryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        // Disovery Details.
        public int CelestialBodyId { get; set; }
        public string CelestialBodyName { get; set; } = null!;

        // Author Details.
        public int UserId { get; set; }
        public string Username { get; set; } = null!;

        // Status Details.
        public int DiscoveryStatusId { get; set; }
        public string DiscoveryStatusLabel { get; set; } = null!;

        public int? AliasStatusId { get; set; }
        public string? AliasStatusLabel { get; set; }
    }
}
