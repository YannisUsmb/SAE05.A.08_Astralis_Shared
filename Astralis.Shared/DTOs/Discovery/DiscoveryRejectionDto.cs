using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs;

public class DiscoveryRejectionDto
{
    [Required(ErrorMessage = "Le motif est obligatoire.")]
    public string Reason { get; set; } = string.Empty;
}