namespace Astralis.Shared.DTOs
{
    public class ArticleFilterDto
    {
        public string? SearchTerm { get; set; }
        public List<int>? TypeIds { get; set; }
        public bool? IsPremium { get; set; }
    }
}