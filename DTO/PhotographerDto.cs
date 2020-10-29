using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PhotographerDto
    {
        [Required]
        public int PhotographerId { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        public String LName { get; set; }
        [Required]
        public String Gender { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String WorkTitle { get; set; }
        [Required]
        public String Country { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String ProfilePictureName { get; set; }


    }
}