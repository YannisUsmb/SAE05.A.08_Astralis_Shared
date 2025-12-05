using System.ComponentModel.DataAnnotations;

namespace Astralis.Shared.DTOs;

public class OrderDetailUpdateDto
{
    [Required]
    public int CommandId { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
    public int Quantity { get; set; }
}