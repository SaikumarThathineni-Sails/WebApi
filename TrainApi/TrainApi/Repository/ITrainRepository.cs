using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;

namespace TrainApi.Repository
{
    public interface ITrainRepository
    {
        List<Train> GetTrains();
        Train InsertingData(Train train);
        Train UpdateTrain(Train train);
        Train FindTrain(int id);
        List<Train> FindWithdate(string date);
    }
}
