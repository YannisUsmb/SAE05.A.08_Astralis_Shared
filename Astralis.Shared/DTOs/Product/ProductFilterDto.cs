namespace Astralis.Shared.DTOs
{
    public class ProductFilterDto
    {
        public string? SearchText { get; set; }
        public List<int>? ProductCategoryIds { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}