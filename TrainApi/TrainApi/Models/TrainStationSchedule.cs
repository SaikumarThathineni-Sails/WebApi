using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainApi.Models
{
    public class TrainStationSchedule
    {
        public int Train_Id { get; set; }
        public int S_Id { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string Dt { get; set; }



    }
}
