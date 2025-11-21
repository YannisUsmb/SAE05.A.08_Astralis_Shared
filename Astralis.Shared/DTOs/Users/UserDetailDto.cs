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
        public char? Gender { get; set; }

        public int UserRoleId { get; set; }
    }
}
