using Microsoft.AspNetCore.Mvc;
using MusicApi1.Data;
using MusicApi1.Models;
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
        private ApiDbContext _DbContext;
        public SongsController(ApiDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _DbContext.Songs;
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            var song= _DbContext.Songs.Find(id);
            return song;
        }

        // POST api/<SongsController>
        [HttpPost]
        public void Post([FromBody] Song song)
        {
            _DbContext.Songs.Add(song);
            _DbContext.SaveChanges();
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Song songObj)
        {
            var song = _DbContext.Songs.Find(id);
            song.SongTitle = songObj.SongTitle;
            song.SongLanguage = songObj.SongLanguage;
            _DbContext.SaveChanges();
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var song = _DbContext.Songs.Find(id);
            _DbContext.Songs.Remove(song);
            _DbContext.SaveChanges();
        }
    }
}
