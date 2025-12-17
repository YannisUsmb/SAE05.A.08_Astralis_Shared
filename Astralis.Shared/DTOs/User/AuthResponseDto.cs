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
        public bool IsPremium { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AuthResponseDto dto &&
                   Token == dto.Token &&
                   Expiration == dto.Expiration &&
                   Username == dto.Username &&
                   Role == dto.Role &&
                   AvatarPath == dto.AvatarPath;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Token, Expiration, Username, Role, AvatarPath);
        }
    }
}
