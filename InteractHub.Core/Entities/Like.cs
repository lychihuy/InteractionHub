namespace InteractHub.Core.Entities;
public class Like
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign Keys
    public string UserId { get; set; }
    public int? PostId { get; set; }
    public int? CommentId { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public Post? Post { get; set; }
    public Comment? Comment { get; set; }
}