using Astralis.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Le nom de famille est requis.")]
        [StringLength(100, ErrorMessage = "Le nom de famille ne peut pas dépasser 100 caractères.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Le prénom est requis.")]
        [StringLength(100, ErrorMessage = "Le prénom ne peut pas dépasser 100 caractères.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "L'adresse e-mail est requise.")]
        [StringLength(250, ErrorMessage = "L'adresse e-mail ne peut pas dépasser 250 caractères.")]
        [EmailAddress(ErrorMessage = "Format d'adresse e-mail invalide.")]
        public string Email { get; set; } = null!;

        public int? CountryId { get; set; }

        [StringLength(20, ErrorMessage = "Le numéro de téléphone ne peut pas dépasser 20 caractères.")]
        [Phone(ErrorMessage = "Format de numéro de téléphone invalide.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        [StringLength(50, ErrorMessage = "Le nom d'utilisateur ne peut pas dépasser 50 caractères.")]
        [RegularExpression(@"^[a-zA-Z0-9._-]+$", ErrorMessage = "Le nom d'utilisateur ne peut contenir que des lettres, chiffres, points, tirets et underscores.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 13, ErrorMessage = "Le mot de passe doit faire entre 13 et 100 caractères")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$", ErrorMessage = " Le mot de passe doit contenir au moins une lettre majuscule, un chiffre et un caractère spécial.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez confirmer le mot de passe.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Le mot de passe et sa confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "Le genre est requis.")]
        public GenderType Gender { get; set; }

        [Required(ErrorMessage = "Le statut de l'authentification multi-facteurs est requis.")]
        public bool MultiFactorAuthentification { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrWhiteSpace(Phone) && !CountryId.HasValue)
            {
                yield return new ValidationResult(
                    "L'indicatif pays est requis si un numéro de téléphone est saisi.",
                    new[] { nameof(CountryId) });
            }
        }
    }
}