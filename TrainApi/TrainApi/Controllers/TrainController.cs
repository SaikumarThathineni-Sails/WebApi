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
    [Route("api/Train")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        public ITrainRepository  _trainrepository;



        public TrainController(ITrainRepository trainRepository)
        {
            _trainrepository = trainRepository;
        }


        // GET: api/<TrainController>
        [HttpGet]
        public IEnumerable<Train> GetTrains()
        {
            return (IEnumerable<Train>)_trainrepository.GetTrains();
        }

        // GET api/<TrainController>/5
        [HttpGet("{id}")]
        public Train FindTrain(int id)
        {
            return _trainrepository.FindTrain(id);
        }
        [HttpGet("date")]
        public List<Train> FindWithdate(string date)
        {
            return  _trainrepository.FindWithdate(date);
        }

        // POST api/<TrainController>
        [HttpPost]
        public Train InsertData([FromBody] Train train)
        {
            _trainrepository.InsertingData(train);
            return train;
        }

        // PUT api/<TrainController>/5
        [HttpPut("{id}")]
        public Train UpdateTrain ( [FromBody] Train train)
        {
            _trainrepository.UpdateTrain(train);
            return train;
        }

       
    }
}
