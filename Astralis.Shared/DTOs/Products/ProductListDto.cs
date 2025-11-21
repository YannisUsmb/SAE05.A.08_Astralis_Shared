namespace Astralis.Shared.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public decimal Price { get; set; }

        // Category Info.
        public int ProductCategoryId { get; set; }
        public string CategoryLabel { get; set; } = null!;
    }
}
