

using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PhotosDto
    {
        [Required]
        public int photosId { get; set; }
        [Required]
        public string PhotographerId { get; set; }
        [Required]

        public string PhotosName { get; set; }


    }
}