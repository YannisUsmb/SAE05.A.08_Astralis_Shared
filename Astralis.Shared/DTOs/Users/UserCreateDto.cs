using Astralis.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs.Users
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

        [StringLength(20, ErrorMessage = "The phone number cannot be longer than 20 caracters.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "The username is required.")]
        [StringLength(50, ErrorMessage = "The username cannot be longer than 50 caracters.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "The password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "The inscription date is required.")]
        public DateOnly InscriptionDate { get; set; }

        [Required(ErrorMessage = "The gender is required.")]
        public GenderType Gender { get; set; }

        [Required(ErrorMessage = "The premium status is required.")]
        public bool IsPremium { get; set; }

        [Required(ErrorMessage = "The multi-factor authentication status is required.")]
        public bool MultiFactorAuthentification { get; set; }

        // Role Info.
        [Required(ErrorMessage = "The role ID for the user is required.")]
        public int RoleId { get; set; }
    }
}
