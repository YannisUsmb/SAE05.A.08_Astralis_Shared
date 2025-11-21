namespace Astralis.Shared.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
