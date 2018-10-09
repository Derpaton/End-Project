using System.ComponentModel.DataAnnotations;

namespace End_Project.Models
{
    public class Users
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        
    }
}