using System;
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
    public class AuthenticationController : ControllerBase
    {
        private readonly IRepository<Photographer> _repo;
        private readonly IMapper _mapper;
        public AuthenticationController(IRepository<Photographer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("getAllAuthentictedUser")]

        public async Task<IActionResult> GetPhotographer()
        {
            var model = await _repo.GetData();
            return Ok(_mapper.Map<IEnumerable<AuthenticationDto>>(model));
        }


    }
}
