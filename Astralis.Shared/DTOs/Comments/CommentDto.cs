namespace Astralis.Shared.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }

        // To reconstruct the thread on the Frontend.
        public int? RepliesToId { get; set; }

        public string Text { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool IsVisible { get; set; }

        // User info.
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserAvatarUrl { get; set; } = null!;
    }
}
