using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryModerationDto
    {
        [Required(ErrorMessage = "The discovery status ID is required.")]
        public int DiscoveryStatusId { get; set; }

        public int AliasStatusId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryModerationDto dto &&
                   DiscoveryStatusId == dto.DiscoveryStatusId &&
                   AliasStatusId == dto.AliasStatusId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DiscoveryStatusId, AliasStatusId);
        }
    }
}
