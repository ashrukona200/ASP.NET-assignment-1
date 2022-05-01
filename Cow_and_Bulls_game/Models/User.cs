using System.ComponentModel.DataAnnotations;

namespace Cow_and_Bulls_game.Models
{
    public class User
    {
        [Required]
        [Display(Name ="Please enter username : ")]
        public string UserId { get; set; } 
        [Required]
        [Display(Name = "Please enter password : ")]
        public string Password { get; set; }
    }
}
