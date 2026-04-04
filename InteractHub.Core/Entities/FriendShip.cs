namespace InteractHub.Core.Entities;
public enum FriendshipStatus
{
    Pending,
    Accepted,
    Declined,
    Blocked
}

public class Friendship
{
    public int Id { get; set; }
    public FriendshipStatus Status { get; set; } = FriendshipStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Foreign Keys
    public string SenderId { get; set; }
    public string ReceiverId { get; set; }

    // Navigation Properties
    public User Sender { get; set; }
    public User Receiver { get; set; }
}