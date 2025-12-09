using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class CommandUpdateDto
    {
        // No UserId or CommandId here; those are derived from context and URL.

        [Required(ErrorMessage = "The command status ID is required.")]
        public int CommandStatusId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CommandUpdateDto dto &&
                   CommandStatusId == dto.CommandStatusId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CommandStatusId);
        }
    }
}
