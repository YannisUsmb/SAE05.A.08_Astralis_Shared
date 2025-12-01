namespace Astralis.Shared.DTOs
{
    public class ArticleListDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsPremium { get; set; }

        // Content substring from the Controller.
        public string Preview { get; set; } = null!;

        // Author Info.
        public int UserId { get; set; }
        public string AuthorUsername { get; set; } = null!;
        public string AuthorAvatarUrl { get; set; } = null!;

        // Computed properties.
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
    }
}
