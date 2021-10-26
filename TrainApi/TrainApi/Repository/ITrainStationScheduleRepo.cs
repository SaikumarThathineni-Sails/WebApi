using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;

namespace TrainApi.Repository
{
    public interface ITrainStationScheduleRepo
    {
        TrainStationSchedule InsertingData(TrainStationSchedule trainStationSchedule);
        IEnumerable<TrainStationSchedule> FindTrains(int sid, string Time);
        List<TrainStationSchedule> GetSchedule();
        List<TrainStationSchedule> GetStations(int Tid, string Time);
    }
}
