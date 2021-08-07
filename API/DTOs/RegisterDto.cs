// for validation
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        // for validation 
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}