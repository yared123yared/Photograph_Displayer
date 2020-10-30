

using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PhotosDto
    {
        [Required]
        public int PhotosId { get; set; }
        [Required]
        public string PhotographerEmail { get; set; }
        [Required]

        public string PhotosName { get; set; }


    }
}