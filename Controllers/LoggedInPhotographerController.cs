
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
    public class LoggedInPhotographerController : ControllerBase
    {
        private readonly IRepository<LoggedInPhotographer> _repo;
        private readonly IMapper _mapper;
        public LoggedInPhotographerController(IRepository<LoggedInPhotographer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("getAllLogedInPhotographers")]

        public async Task<IActionResult> GetPhotographer()
        {
            var model = await _repo.GetLoggedInUsers();
            return Ok(model);
        }








        [HttpPost("InsertLogedInPhotographer")]

        public async Task<IActionResult> CreatePhotographer(LoggedInPhotographer photographer)
        {
            Console.WriteLine("this is the InsertPhotographer method controlller");
            // here will be the insert method

            await _repo.InsertLoggedInUser(photographer);
            return Ok(photographer);
        }



















    }
}
