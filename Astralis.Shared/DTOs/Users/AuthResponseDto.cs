namespace Astralis.Shared.DTOs
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = null!;
        public DateTime Expiration { get; set; }

        // User Info: no need to GET user info separately after authentication.
        public string Username { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? AvatarPath { get; set; }
    }
}
