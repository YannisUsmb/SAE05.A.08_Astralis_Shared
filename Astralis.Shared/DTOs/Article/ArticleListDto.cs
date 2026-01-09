
namespace Astralis.Shared.DTOs
{
    public class ArticleListDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsPremium { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<string> CategoryNames { get; set; } = new List<string>();

        // Content substring from the Controller.
        public string Preview { get; set; } = null!;

        // Author Info.
        public int UserId { get; set; }
        public string AuthorUsername { get; set; } = null!;
        public string AuthorAvatarUrl { get; set; } = null!;

        // Computed properties.
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ArticleListDto dto &&
                   Id == dto.Id &&
                   Title == dto.Title &&
                   IsPremium == dto.IsPremium &&
                   Preview == dto.Preview &&
                   UserId == dto.UserId &&
                   AuthorUsername == dto.AuthorUsername &&
                   AuthorAvatarUrl == dto.AuthorAvatarUrl &&
                   LikesCount == dto.LikesCount &&
                   CommentsCount == dto.CommentsCount;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Title);
            hash.Add(IsPremium);
            hash.Add(Preview);
            hash.Add(UserId);
            hash.Add(AuthorUsername);
            hash.Add(AuthorAvatarUrl);
            hash.Add(LikesCount);
            hash.Add(CommentsCount);
            return hash.ToHashCode();
        }
    }
}
