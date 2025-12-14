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
        public string UserAvatarUrl { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateOnly InscriptionDate { get; set; }
        public GenderType Gender { get; set; }
        public bool IsPremium { get; set; }
        public bool MultiFactorAuthentification { get; set; }

        // Role Info.
        public int RoleId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserDetailDto dto &&
                   Id == dto.Id &&
                   LastName == dto.LastName &&
                   FirstName == dto.FirstName &&
                   Email == dto.Email &&
                   Phone == dto.Phone &&
                   Username == dto.Username &&
                   UserAvatarUrl == dto.UserAvatarUrl &&
                   Password == dto.Password &&
                   InscriptionDate.Equals(dto.InscriptionDate) &&
                   Gender == dto.Gender &&
                   IsPremium == dto.IsPremium &&
                   MultiFactorAuthentification == dto.MultiFactorAuthentification &&
                   RoleId == dto.RoleId;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(LastName);
            hash.Add(FirstName);
            hash.Add(Email);
            hash.Add(Phone);
            hash.Add(Username);
            hash.Add(UserAvatarUrl);
            hash.Add(Password);
            hash.Add(InscriptionDate);
            hash.Add(Gender);
            hash.Add(IsPremium);
            hash.Add(MultiFactorAuthentification);
            hash.Add(RoleId);
            return hash.ToHashCode();
        }
    }
}
