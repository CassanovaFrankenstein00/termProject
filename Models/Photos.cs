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
        [Display(Name = "Photo Title")]
        [StringLength(20, ErrorMessage = "Please enter a title of 20 words or less.")]
        public string Title { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9\s,.'-]{0,40}$", ErrorMessage = "Description can only contain letters, 	numbers, spaces, and basic punctuation.")]
        [StringLength(40, ErrorMessage = "Please enter a description of 40 words or less.")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Photo Credit")]
        [StringLength(20, ErrorMessage = "Please enter a credit of 20 words or less.")]
        public string Credit { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Please enter a valid URL of 200 characters or less.")]
        public string ImageUrl { get; set; }
        public Type? PhotoType { get; set; } = null;

        [DataType(DataType.Date)]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; } = null;

        public string? Location { get; set; } = null;

    }
}
