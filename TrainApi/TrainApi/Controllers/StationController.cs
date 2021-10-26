using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;
using TrainApi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        public IStationRepository _stationrepository;



        public StationController(IStationRepository stationRepository )
        {
            _stationrepository = stationRepository;
        }



        // GET: api/<StationController>
        [HttpGet]
        public IEnumerable<Station> GetStations()
        {
            return _stationrepository.GetStations();
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public Station GetStation(int id)
        {
            return _stationrepository.FindStation(id);
        }

        // POST api/<StationController>
        [HttpPost]
        public Station InsertData([FromBody] Station station)
        {
            return _stationrepository.InsertingData(station);
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
