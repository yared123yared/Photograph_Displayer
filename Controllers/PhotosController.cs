using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotosController : ControllerBase
    {
        private readonly IRepository<Photos> _repo;
        private readonly IMapper _mapper;
        public PhotosController(IRepository<Photos> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("getAllPhotos")]

        public async Task<IActionResult> GetPhotos()
        {
            var model = await _repo.GetData();
            return Ok(_mapper.Map<IEnumerable<PhotosDto>>(model));
        }
        [HttpGet("getAllPhotosById")]
        public async Task<IActionResult> GetPhotosById(int id)
        {
            // here will be the department get by id method
            var model = await _repo.GetDataById(id);
            return Ok(_mapper.Map<PhotosDto>(model));
        }
        [HttpPost("InsertPhotos")]
        public async Task<IActionResult> CreateDeoartment(PhotosDto photosDto)
        {
            // here will be the insert method
            var photos = _mapper.Map<Photos>(photosDto);
            await _repo.UpdateData(photos);
            return Ok(photosDto);
        }
        [HttpDelete("deletePhotos")]
        public async Task<IActionResult> DeletePhotos(PhotosDto photosDto)
        {
            var photos = _mapper.Map<Photos>(photosDto);
            await _repo.DeleteData(photos);
            return Ok(photosDto);

        }
        [HttpGet("getPhotosByEmail")]
        public async Task<IActionResult> GetPhotosByEmail(string email)
        {   
            // get photographer by email address after authentication
            var model = await _repo.GetPhotosByEmail(email);
            // return Ok(_mapper.Map<PhotosDto>(model));
            return Ok(model);

        }

    }
}
