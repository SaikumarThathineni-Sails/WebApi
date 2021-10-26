using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;

namespace TrainApi.Repository
{
    public class TrainStationScheduleRepo : ITrainStationScheduleRepo
    {
        private readonly IDbConnection db;


        public TrainStationScheduleRepo(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public TrainStationSchedule InsertingData(TrainStationSchedule trainStationSchedule)
        {
            var sql = "INSERT INTO TrainStationSchedule(Train_Id,S_Id,ArrivalTime,DepartureTime,Dt) VALUES(@Train_Id,@S_Id,@ArrivalTime,@DepartureTime,@Dt)";
            db.Query<int>(sql, new
            {
                trainStationSchedule.Train_Id,
                trainStationSchedule.S_Id,
                trainStationSchedule.ArrivalTime,
                trainStationSchedule.DepartureTime,
                trainStationSchedule.Dt

            });
            return trainStationSchedule;
        }


        public IEnumerable<TrainStationSchedule>  FindTrains(int sid, string Time)
        {
            var sql = "SELECT Train_Id FROM TrainStationSchedule WHERE S_Id=@S_Id AND ArrivalTime=@ArrivalTime";
            return  db.Query<TrainStationSchedule>(sql, new { S_Id = sid, ArrivalTime= Time }).ToList();
        }

        public List<TrainStationSchedule> GetSchedule()
        {
            var sql = "SELECT * FROM TrainStationSchedule";
            return db.Query<TrainStationSchedule>(sql).ToList();
        }

        public List<TrainStationSchedule> GetStations(int Tid, string Time)
        {
            var sql = "SELECT * FROM TrainStationSchedule WHERE Train_Id = @Train_Id AND ArrivalTime=@ArrivalTime";
            return db.Query<TrainStationSchedule>(sql, new { Train_Id = Tid, ArrivalTime = Time }).ToList();
        }
    }
}
