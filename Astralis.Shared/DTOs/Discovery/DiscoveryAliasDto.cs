using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class DiscoveryAliasDto
    {
        [Required(ErrorMessage = "The alias is required.")]
        [StringLength(100, ErrorMessage = "The alias cannot be longer than 100 characters.")]
        public string Alias { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is DiscoveryAliasDto dto &&
                   Alias == dto.Alias;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Alias);
        }
    }
}