using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class EventUpdateDto : IValidatableObject
    {
        [Required(ErrorMessage = "L'id du type d'événement est requis.")]
        public int EventTypeId { get; set; }

        // User ID will be taken from the authenticated user context.

        [Required(ErrorMessage = "Le titre est requis")]
        [StringLength(50, ErrorMessage = "Le titre ne peut pas faire plus de 50 caractères.")]
        public string Title { get; set; } = null!;

        [StringLength(500, ErrorMessage = "La description ne peut pas faire plus de 500 caractères.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "La date de début est requise.")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Url(ErrorMessage = "L'url de l'image doit être une url valide.")]
        public string? PictureUrl { get; set; }

        [StringLength(100, ErrorMessage = "Le lieu ne peut pas faire plus de 100 caractères.")]
        public string? Location { get; set; }

        [Url(ErrorMessage = "Le lien externe doit être une url valide.")]
        public string? Link { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EventUpdateDto dto &&
                   EventTypeId == dto.EventTypeId &&
                   Title == dto.Title &&
                   Description == dto.Description &&
                   StartDate == dto.StartDate &&
                   EndDate == dto.EndDate &&
                   Location == dto.Location &&
                   Link == dto.Link;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EventTypeId, Title, Description, StartDate, EndDate, Location, Link);
        }

        // Custom validation to ensure EndDate is not before StartDate.
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate.HasValue && EndDate < StartDate)
            {
                yield return new ValidationResult(
                    "The end date must be on or after the start date.",
                    new[] { nameof(EndDate), nameof(StartDate) }
                );
            }
        }
    }
}
