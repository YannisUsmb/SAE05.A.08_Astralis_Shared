using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ChangePasswordDto
    {
        [Required(ErrorMessage = "The current password is required.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; } = null!;

        [Required(ErrorMessage = "The new password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "The new password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$", ErrorMessage = "The password must contain at least one uppercase letter, one number, and one special character.")]
        public string NewPassword { get; set; } = null!;

        [Required(ErrorMessage = "Please confirm the new password.")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is ChangePasswordDto dto &&
                   CurrentPassword == dto.CurrentPassword &&
                   NewPassword == dto.NewPassword &&
                   ConfirmNewPassword == dto.ConfirmNewPassword;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CurrentPassword, NewPassword, ConfirmNewPassword);
        }
    }
}
