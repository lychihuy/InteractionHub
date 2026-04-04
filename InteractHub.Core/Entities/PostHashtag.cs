namespace InteractHub.Core.Entities;
public class PostHashtag
{
    // Foreign Keys
    public int PostId { get; set; }
    public int HashtagId { get; set; }

    // Navigation Properties
    public Post Post { get; set; }
    public Hashtag Hashtag { get; set; }
}