namespace Astralis.Shared.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        // Category Info.
        public int CategoryId { get; set; }
        public string CategoryLabel { get; set; } = null!;
    }
}
