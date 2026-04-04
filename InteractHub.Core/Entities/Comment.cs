namespace InteractHub.Core.Entities;
using System.ComponentModel.DataAnnotations;
public class Comment
{
    public int Id { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign Keys
    public string UserId { get; set; }
    public int PostId { get; set; }
    public int? ParentCommentId { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public Post Post { get; set; }
    public Comment? ParentComment { get; set; }
    public ICollection<Comment> Replies { get; set; } = new List<Comment>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
}