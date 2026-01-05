using Astralis.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class UserUpdateDto
    {
        [Required(ErrorMessage = "Le nom de famille est requis.")]
        [StringLength(100, ErrorMessage = "Le nom de famille ne peut pas dépasser 100 caractères.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Le prénom est requis.")]
        [StringLength(100, ErrorMessage = "Le prénom ne peut pas dépasser 100 caractères.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "L'adresse e-mail est requise.")]
        [StringLength(250, ErrorMessage = "L'adresse e-mail ne peut pas dépasser 250 caractères.")]
        [EmailAddress(ErrorMessage = "Le format de l'adresse e-mail est invalide.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        [StringLength(50, ErrorMessage = "Le nom d'utilisateur ne peut pas dépasser 50 caractères.")]
        [RegularExpression(
            @"^[a-zA-Z0-9._-]+$",
            ErrorMessage = "Le nom d'utilisateur ne peut contenir que des lettres, des chiffres, des points, des tirets et des underscores."
        )]
        public string Username { get; set; } = null!;

        [Url(ErrorMessage = "Le format de l'URL de l’avatar est invalide.")]
        public string? AvatarUrl { get; set; }

        public int? CountryId { get; set; }

        [StringLength(20, ErrorMessage = "Le numéro de téléphone ne peut pas dépasser 20 caractères.")]
        [Phone(ErrorMessage = "Le format du numéro de téléphone est invalide.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Le genre est requis.")]
        public GenderType Gender { get; set; }

        [Required(ErrorMessage = "Le paramètre d’authentification multifacteur est requis.")]
        public bool MultiFactorAuthentification { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CountryId.HasValue && string.IsNullOrWhiteSpace(Phone))
            {
                yield return new ValidationResult(
                    "Le numéro de téléphone est requis lorsqu’un indicatif pays est sélectionné.",
                    new[] { nameof(Phone) }
                );
            }

            if (!string.IsNullOrWhiteSpace(Phone) && !CountryId.HasValue)
            {
                yield return new ValidationResult(
                    "L’indicatif pays est requis lorsqu’un numéro de téléphone est renseigné.",
                    new[] { nameof(CountryId) }
                );
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is UserUpdateDto dto &&
                   LastName == dto.LastName &&
                   FirstName == dto.FirstName &&
                   Email == dto.Email &&
                   Username == dto.Username &&
                   AvatarUrl == dto.AvatarUrl &&
                   Phone == dto.Phone &&
                   Gender == dto.Gender &&
                   MultiFactorAuthentification == dto.MultiFactorAuthentification;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                LastName,
                FirstName,
                Email,
                Username,
                AvatarUrl,
                Phone,
                Gender,
                MultiFactorAuthentification
            );
        }
    }
}
