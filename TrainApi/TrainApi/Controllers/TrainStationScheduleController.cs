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
    
    public class TrainStationScheduleController : ControllerBase
    {
        public ITrainStationScheduleRepo _trainStationScheduleRepo;



        public TrainStationScheduleController(ITrainStationScheduleRepo trainStationScheduleRepo)
        {
            _trainStationScheduleRepo = trainStationScheduleRepo;
        }



        // GET: api/<TrainStationScheduleController>
        [HttpGet]
        public List<TrainStationSchedule> GetSchedule()
        {
            return  _trainStationScheduleRepo.GetSchedule();
        }

        // GET api/<TrainStationScheduleController>/5
        [HttpGet("sid,ArrTime")]
        public IEnumerable<TrainStationSchedule> FindTrains(int sid, string ArrTime)
        {
            return  _trainStationScheduleRepo.FindTrains(sid, ArrTime);
        }

        // POST api/<TrainStationScheduleController>
        [Route("Save")]
        [HttpPost]
        public TrainStationSchedule InsertingData([FromBody] TrainStationSchedule trainStationSchedule)
        {
            _trainStationScheduleRepo.InsertingData(trainStationSchedule);
            return trainStationSchedule;
        }

        [HttpGet("Tid,Time")]
        public IEnumerable<TrainStationSchedule> FindStations(int Tid, string Time)
        {
            return _trainStationScheduleRepo.FindStations(Tid, Time);
        }


    }
}
