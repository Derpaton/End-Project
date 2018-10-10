using System.ComponentModel.DataAnnotations;

namespace End_Project.Models
{

    public class Users {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}