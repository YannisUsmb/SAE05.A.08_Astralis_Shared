
namespace Astralis.Shared.DTOs
{
    public class ArticleFilterDto
    {
        public string? SearchTerm { get; set; }
        public List<int>? TypeIds { get; set; }
        public bool? IsPremium { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ArticleFilterDto dto &&
                   SearchTerm == dto.SearchTerm &&
                   EqualityComparer<List<int>?>.Default.Equals(TypeIds, dto.TypeIds) &&
                   IsPremium == dto.IsPremium;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchTerm, TypeIds, IsPremium);
        }
    }
}