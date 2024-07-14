using System.ComponentModel.DataAnnotations;

namespace APIs.DTO
{
    public class LoginDTO
    {

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }



        [Required]
        public string password { get; set; }
    }
}
