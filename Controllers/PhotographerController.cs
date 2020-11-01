using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Model;
using Microsoft.AspNetCore.Cors;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotographerController : ControllerBase
    {
        private readonly IRepository<Photographer> _repo;
        private readonly IMapper _mapper;
        public PhotographerController(IRepository<Photographer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("getAllPhotographers")]

        public async Task<IActionResult> GetPhotographer()
        {
            var model = await _repo.GetData();
            return Ok(_mapper.Map<IEnumerable<PhotographerDto>>(model));
        }
        [HttpGet("getAllPhotographerById")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            // here will be the department get by id method
            var model = await _repo.GetDataById(id);
            return Ok(_mapper.Map<PhotographerDto>(model));
        }
        [HttpPost("InsertPhotographer")]
        [EnableCors("*")]
        public async Task<IActionResult> CreateDeoartment(PhotographerDto photographerDto)
        {
            // here will be the insert method
            var photographer = _mapper.Map<Photographer>(photographerDto);
            await _repo.UpdateData(photographer);
            return Ok(photographerDto);
        }
        [HttpDelete("deletePhotographer")]
        public async Task<IActionResult> DeletePhotographer(PhotographerDto photographerDto)
        {
            var photographer = _mapper.Map<Photographer>(photographerDto);
            await _repo.DeleteData(photographer);
            return Ok(photographerDto);

        }
        [HttpGet("getPhotographerByEmail")]
        public async Task<IActionResult> GetPhotographerByEmail(string email)
        {
            Console.WriteLine("hello");
            // get photographer by email address after authentication
            var model = await _repo.GetDataByEmail(email);
            return Ok(_mapper.Map<PhotographerDto>(model));

        }

    }
}
