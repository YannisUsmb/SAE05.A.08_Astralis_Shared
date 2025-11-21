using Astralis.Shared.Enums;

namespace Astralis.Shared.DTOs
{
    public class UserDetailDto
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateOnly InscriptionDate { get; set; }
        public GenderType Gender { get; set; }
        public bool IsPremium { get; set; }
        public bool MultiFactorAuthentification { get; set; }

        // Role Info.
        public int RoleId { get; set; }
    }
}
