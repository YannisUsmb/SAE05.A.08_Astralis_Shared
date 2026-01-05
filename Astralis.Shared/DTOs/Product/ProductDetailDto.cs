
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astralis.Shared.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }        
        public string? ProductPictureUrl { get; set; }
        public decimal Price { get; set; }
        // Category Info.
        public int CategoryId { get; set; }
        public string CategoryLabel { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is ProductDetailDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label &&
                   Description == dto.Description &&
                   Price == dto.Price &&
                   CategoryId == dto.CategoryId &&
                   CategoryLabel == dto.CategoryLabel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label, Description, Price, CategoryId, CategoryLabel);
        }
    }
}
