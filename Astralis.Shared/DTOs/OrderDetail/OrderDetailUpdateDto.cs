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

    public override bool Equals(object? obj)
    {
        return obj is OrderDetailUpdateDto dto &&
               CommandId == dto.CommandId &&
               ProductId == dto.ProductId &&
               Quantity == dto.Quantity;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CommandId, ProductId, Quantity);
    }
}