namespace InteractHub.Core.Entities;
using System.ComponentModel.DataAnnotations;
public class Hashtag
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public int UsageCount { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Property
    public ICollection<PostHashtag> PostHashtags { get; set; } = new List<PostHashtag>();
}
