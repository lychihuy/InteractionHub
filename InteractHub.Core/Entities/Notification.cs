namespace InteractHub.Core.Entities;
using System.ComponentModel.DataAnnotations;
public enum NotificationType
{
    Like,
    Comment,
    FriendRequest,
    FriendAccepted,
    Share,
    Mention
}

public class Notification
{
    public int Id { get; set; }
    public NotificationType Type { get; set; }

    [MaxLength(500)]
    public string Message { get; set; }
    public bool IsRead { get; set; } = false;
    public int? ReferenceId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign Keys
    public string UserId { get; set; }   // người nhận
    public string SenderId { get; set; } // người gửi

    // Navigation Properties
    public User User { get; set; }
    public User Sender { get; set; }
}