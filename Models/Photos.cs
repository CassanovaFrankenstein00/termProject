using System.ComponentModel.DataAnnotations;

namespace termProjectPhotoApp.Models
{
    public enum Type
    {
        Action,
        Landscape,
        Portait,
        Wildlife,
        Astro,
        Macro
        
    }
    public class Photos
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [StringLength(40, ErrorMessage="Please enter a description of 40 words or less.")]
        public string? Description { get; set; }
        [Required]
        public string Credit { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public Type? PhotoType { get; set; } = null;

    }
}
