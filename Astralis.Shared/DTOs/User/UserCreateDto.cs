using Astralis.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "The lastname is required.")]
        [StringLength(100, ErrorMessage = "The lastname cannot be longer than 100 caracters.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "The firstname is required.")]
        [StringLength(100, ErrorMessage = "The firstname cannot be longer than 100 caracters.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The email is required.")]
        [StringLength(250, ErrorMessage = "The email cannot be longer than 250 caracters.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "The country is required.")]
        public int? CountryId { get; set; }

        [StringLength(20, ErrorMessage = "The phone number cannot be longer than 20 caracters.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "The username is required.")]
        [StringLength(50, ErrorMessage = "The username cannot be longer than 50 caracters.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "The user avatar URL is required.")]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string UserAvatarUrl { get; set; } = null!;

        [Required(ErrorMessage = "The password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "The password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$", ErrorMessage = "The password must contain at least one uppercase letter, one number, and one special character.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Please confirm the password.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "The gender is required.")]
        public GenderType Gender { get; set; }

        [Required(ErrorMessage = "The multi-factor authentication status is required.")]
        public bool MultiFactorAuthentification { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserCreateDto dto &&
                   LastName == dto.LastName &&
                   FirstName == dto.FirstName &&
                   Email == dto.Email &&
                   Phone == dto.Phone &&
                   Username == dto.Username &&
                   UserAvatarUrl == dto.UserAvatarUrl &&
                   Password == dto.Password &&
                   ConfirmPassword == dto.ConfirmPassword &&
                   Gender == dto.Gender &&
                   MultiFactorAuthentification == dto.MultiFactorAuthentification;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(LastName);
            hash.Add(FirstName);
            hash.Add(Email);
            hash.Add(Phone);
            hash.Add(Username);
            hash.Add(UserAvatarUrl);
            hash.Add(Password);
            hash.Add(ConfirmPassword);
            hash.Add(Gender);
            hash.Add(MultiFactorAuthentification);
            return hash.ToHashCode();
        }
    }
}
