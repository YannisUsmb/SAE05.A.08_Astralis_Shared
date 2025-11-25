using Astralis.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserUpdateDto
    {
        [Required(ErrorMessage = "The lastname is required.")]
        [StringLength(100, ErrorMessage = "The lastname cannot be longer than 100 characters.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "The firstname is required.")]
        [StringLength(100, ErrorMessage = "The firstname cannot be longer than 100 characters.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The email is required.")]
        [StringLength(250, ErrorMessage = "The email cannot be longer than 250 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "The username is required.")]
        [StringLength(50, ErrorMessage = "The username cannot be longer than 50 characters.")]
        public string Username { get; set; } = null!;

        [StringLength(20, ErrorMessage = "The phone number cannot be longer than 20 characters.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "The gender is required.")]
        public GenderType Gender { get; set; }

        [Required]
        public bool MultiFactorAuthentification { get; set; }
    }
}
