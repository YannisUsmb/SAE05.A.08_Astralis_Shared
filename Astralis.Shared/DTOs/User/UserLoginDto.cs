using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserLoginDto : IValidatableObject
    {
        public string? Identifier { get; set; }

        public int? CountryId { get; set; }
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Identifier) && string.IsNullOrWhiteSpace(Phone))
            {
                yield return new ValidationResult(
                    "Veuillez saisir un identifiant (Email/Pseudo) ou un numéro de téléphone.",
                    new[] { nameof(Identifier) });
            }

            if (!string.IsNullOrWhiteSpace(Phone) && !CountryId.HasValue)
            {
                yield return new ValidationResult(
                    "Veuillez sélectionner un pays pour la connexion par téléphone.",
                    new[] { nameof(CountryId) });
            }

            if (CountryId.HasValue && string.IsNullOrWhiteSpace(Phone))
            {
                yield return new ValidationResult(
                    "Veuillez saisir votre numéro de téléphone.",
                    new[] { nameof(Phone) });
            }
        }
    }
}