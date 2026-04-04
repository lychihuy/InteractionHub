namespace InteractHub.Core.Entities;
public class Post
{
    public int Id { get; set; }
    public string Content { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign Key
    public string UserId { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<PostHashtag> PostHashtags { get; set; } = new List<PostHashtag>();
    public ICollection<PostReport> PostReports { get; set; } = new List<PostReport>();
}