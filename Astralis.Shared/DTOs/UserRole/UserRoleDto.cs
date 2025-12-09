
namespace Astralis.Shared.DTOs
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is UserRoleDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label);
        }
    }
}
