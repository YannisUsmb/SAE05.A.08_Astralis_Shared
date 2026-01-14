using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs
{
    public class EventTypeCreateDto
    {
        [Required(ErrorMessage = "Le libellé est requis.")]
        [StringLength(50, ErrorMessage = "Le libellé ne peut pas faire plus de 50 caractères.")]
        public string Label { get; set; } = null!;

        [Required(ErrorMessage = "La description est requise.")]
        [StringLength(300, ErrorMessage = "La description ne peut pas faire plus de 300 caractères.")]
        public string Description { get; set; } = null!;
    }
}
