using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AuthenticationDto
    {
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
























