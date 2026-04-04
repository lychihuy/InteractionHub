using Microsoft.AspNetCore.Identity;

namespace InteractHub.Core.Entities;
public class User : IdentityUser
{
    public string FullName { get; set; }
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Posts
    public ICollection<Post> Posts { get; set; } = new List<Post>();

    // Comments
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    // Likes
    public ICollection<Like> Likes { get; set; } = new List<Like>();

    // Stories
    public ICollection<Story> Stories { get; set; } = new List<Story>();

    // Friendships
    public ICollection<Friendship> SentFriendships { get; set; } = new List<Friendship>();
    public ICollection<Friendship> ReceivedFriendships { get; set; } = new List<Friendship>();

    // Notifications
    public ICollection<Notification> ReceivedNotifications { get; set; } = new List<Notification>();
    public ICollection<Notification> SentNotifications { get; set; } = new List<Notification>();

    // Reports
    public ICollection<PostReport> PostReports { get; set; } = new List<PostReport>();
}