
namespace Astralis.Shared.DTOs
{
    public class ProductFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? ProductCategoryIds { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ProductFilterDto dto &&
                   SearchText == dto.SearchText &&
                   EqualityComparer<List<int>?>.Default.Equals(ProductCategoryIds, dto.ProductCategoryIds) &&
                   MinPrice == dto.MinPrice &&
                   MaxPrice == dto.MaxPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchText, ProductCategoryIds, MinPrice, MaxPrice);
        }
    }
}