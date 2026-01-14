
namespace Astralis.Shared.DTOs
{
    public class DiscoveryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        // Disovery Details.
        public int CelestialBodyId { get; set; }
        public string CelestialBodyName { get; set; } = null!;

        public string CelestialBodyTypeName { get; set; } = string.Empty;
        
        // Author Details.
        public int UserId { get; set; }
        public string Username { get; set; } = null!;

        // Status Details.
        public int DiscoveryStatusId { get; set; }
        public string DiscoveryStatusLabel { get; set; } = null!;

        public int? AliasStatusId { get; set; }
        public string? AliasStatusLabel { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryDto dto &&
                   Id == dto.Id &&
                   Title == dto.Title &&
                   CelestialBodyId == dto.CelestialBodyId &&
                   CelestialBodyName == dto.CelestialBodyName &&
                   UserId == dto.UserId &&
                   Username == dto.Username &&
                   DiscoveryStatusId == dto.DiscoveryStatusId &&
                   DiscoveryStatusLabel == dto.DiscoveryStatusLabel &&
                   AliasStatusId == dto.AliasStatusId &&
                   AliasStatusLabel == dto.AliasStatusLabel;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Title);
            hash.Add(CelestialBodyId);
            hash.Add(CelestialBodyName);
            hash.Add(UserId);
            hash.Add(Username);
            hash.Add(DiscoveryStatusId);
            hash.Add(DiscoveryStatusLabel);
            hash.Add(AliasStatusId);
            hash.Add(AliasStatusLabel);
            return hash.ToHashCode();
        }
    }
}
