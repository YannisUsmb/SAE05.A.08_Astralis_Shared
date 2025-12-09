
namespace Astralis.Shared.DTOs
{
    public class TypeOfArticleDto
    {
        public int ArticleTypeId { get; set; }
        public int ArticleId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TypeOfArticleDto dto &&
                   ArticleTypeId == dto.ArticleTypeId &&
                   ArticleId == dto.ArticleId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArticleTypeId, ArticleId);
        }
    }
}
