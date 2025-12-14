
namespace Astralis.Shared.DTOs
{
    public class ArticleInterestDto
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ArticleInterestDto dto &&
                   ArticleId == dto.ArticleId &&
                   UserId == dto.UserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ArticleId, UserId);
        }
    }
}
