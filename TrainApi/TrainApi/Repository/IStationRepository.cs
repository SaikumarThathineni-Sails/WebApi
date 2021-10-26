using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;

namespace TrainApi.Repository
{
    public interface IStationRepository
    {
        Station FindStation(int id);
        List<Station> GetStations();
        Station InsertingData(Station station);
        Station UpdateStation(Station station);
        public Station Delete(int id);
    }
}
