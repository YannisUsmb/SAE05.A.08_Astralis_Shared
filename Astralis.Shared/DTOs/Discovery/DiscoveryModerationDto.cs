using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryModerationDto
    {
        [Required(ErrorMessage = "The discovery status ID is required.")]
        public int DiscoveryStatusId { get; set; }

        public int AliasStatusId { get; set; }
    }
}
