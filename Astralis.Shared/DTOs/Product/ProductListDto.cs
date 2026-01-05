
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astralis.Shared.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? ProductPictureUrl { get; set; }        
        public decimal Price { get; set; }
        // Category Info.
        public int CategoryId { get; set; }
        public string CategoryLabel { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is ProductListDto dto &&
                   Id == dto.Id &&
                   Label == dto.Label &&
                   Price == dto.Price &&
                   CategoryId == dto.CategoryId &&
                   CategoryLabel == dto.CategoryLabel;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Label, Price, CategoryId, CategoryLabel);
        }
    }
}
