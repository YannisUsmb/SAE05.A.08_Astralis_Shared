namespace Astralis.Shared.DTOs
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string? Description { get; set; }
    }
}
