using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture required!!!")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name required!!!")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Full Name must be between 3 to 50 characters ")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required!!")]
        public string? Bio { get; set; }

        //Relationship

        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}
