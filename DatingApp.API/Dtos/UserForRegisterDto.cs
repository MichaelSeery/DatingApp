using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=3, ErrorMessage = "You must specify a password between 3 and 8 characters")]
        public string Password { get; set; }
    }
}