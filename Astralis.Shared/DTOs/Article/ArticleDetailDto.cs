
namespace Astralis.Shared.DTOs
{
    public class ArticleDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsPremium { get; set; }

        // Author Info.
        public int UserId { get; set; }
        public string AuthorUsername { get; set; } = null!;
        public string AuthorAvatarUrl { get; set; } = null!;

        // Categories Info.
        public List<int> CategoryIds { get; set; } = new List<int>();
        public List<string> CategoryNames { get; set; } = new List<string>();

        public override bool Equals(object? obj)
        {
            return obj is ArticleDetailDto dto &&
                   Id == dto.Id &&
                   Title == dto.Title &&
                   Content == dto.Content &&
                   IsPremium == dto.IsPremium &&
                   UserId == dto.UserId &&
                   AuthorUsername == dto.AuthorUsername &&
                   AuthorAvatarUrl == dto.AuthorAvatarUrl &&
                   EqualityComparer<List<int>>.Default.Equals(CategoryIds, dto.CategoryIds) &&
                   EqualityComparer<List<string>>.Default.Equals(CategoryNames, dto.CategoryNames);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Title);
            hash.Add(Content);
            hash.Add(IsPremium);
            hash.Add(UserId);
            hash.Add(AuthorUsername);
            hash.Add(AuthorAvatarUrl);
            hash.Add(CategoryIds);
            hash.Add(CategoryNames);
            return hash.ToHashCode();
        }
    }
}
