using System.ComponentModel.DataAnnotations;

namespace InteractHub.Core.DTOs.Posts;

public class CreatePostDto
{
    [Required]
    [MaxLength(2000)]
    public string Content { get; set; } = string.Empty;

    public IFormFile? Image { get; set; } // upload ảnh
}