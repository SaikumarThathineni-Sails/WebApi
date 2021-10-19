using Microsoft.AspNetCore.Mvc;
using MusicApi1.Models;
using MusicApi1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly IMusicRepository _musicrepository;



        public SongsController(IMusicRepository musicRepository)
        {
            _musicrepository = musicRepository;
        }


        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return (IEnumerable<Song>)_musicrepository.Get();
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public Song Find(int id)
        {
            return _musicrepository.Find(id);
        }

    }   
}

    