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
        public string Username { get; set; } = null!;
        public string UserAvatarUrl { get; set; } = null!;

        public List<CommentDto> Replies { get; set; } = new();

        public override bool Equals(object? obj)
        {
            return obj is CommentDto dto &&
                   Id == dto.Id &&
                   ArticleId == dto.ArticleId &&
                   RepliesToId == dto.RepliesToId &&
                   Text == dto.Text &&
                   Date == dto.Date &&
                   IsVisible == dto.IsVisible &&
                   UserId == dto.UserId &&
                   Username == dto.Username &&
                   UserAvatarUrl == dto.UserAvatarUrl;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(ArticleId);
            hash.Add(RepliesToId);
            hash.Add(Text);
            hash.Add(Date);
            hash.Add(IsVisible);
            hash.Add(UserId);
            hash.Add(Username);
            hash.Add(UserAvatarUrl);
            return hash.ToHashCode();
        }
    }
}
