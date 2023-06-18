using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SocialMedia.Core.DTOs
{
    public class PostDto
    {
        [Required(ErrorMessage = "UserId es obligatorio.")]
        public int? UserId { get; set; }
        public int PostId { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
