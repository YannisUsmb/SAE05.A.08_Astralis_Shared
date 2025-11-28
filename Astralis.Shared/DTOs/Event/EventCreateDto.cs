using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class EventCreateDto : IValidatableObject
    {
        [Required(ErrorMessage = "The event type ID is required.")]
        public int EventTypeId { get; set; }

        // User ID will be taken from the authenticated user context.

        [Required(ErrorMessage = "The title is required.")]
        [StringLength(50, ErrorMessage = "The title cannot be longer than 50 characters.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "The description is required.")]
        [StringLength(500, ErrorMessage = "The description cannot be longer than 500 characters.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "The start date is required.")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(100, ErrorMessage = "The location cannot be longer than 100 characters.")]
        public string? Location { get; set; }

        [Url(ErrorMessage = "The link must be a valid URL.")]
        public string? Link { get; set; }

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
