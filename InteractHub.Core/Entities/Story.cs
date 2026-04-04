namespace InteractHub.Core.Entities;
public class Story
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? ImageUrl { get; set; }
    public string? BackgroundColor { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; } = DateTime.UtcNow.AddHours(24);
    public bool IsExpired => DateTime.UtcNow > ExpiresAt;

    // Foreign Key
    public string UserId { get; set; }

    // Navigation Property
    public User User { get; set; }
}