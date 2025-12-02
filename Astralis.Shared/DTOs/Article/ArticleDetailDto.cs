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
    }
}
