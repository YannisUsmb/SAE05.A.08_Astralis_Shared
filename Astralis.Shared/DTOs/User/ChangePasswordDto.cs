using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class ChangePasswordDto
    {
        [Required(ErrorMessage = "Le mot de passe actuel est requis.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; } = null!;

        [Required(ErrorMessage = "Le nouveau mot de passe est requis.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 13, ErrorMessage = "Le nouveau mot de passe doit faire entre 13 et 100 caractères.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$", ErrorMessage = " Le nouveau mot de passe doit comporter une lettre majuscule, un chiffre et un caractère spécial.")]
        public string NewPassword { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez confirmer le nouveau mot de passe.")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "Le mot de passe et sa confirmation ne correspondent pas.")] 
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
