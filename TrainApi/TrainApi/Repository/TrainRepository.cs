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
    public class TrainRepository : ITrainRepository
    {
        private readonly IDbConnection db;

        
        public TrainRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }



        public Train FindTrain(int id)
        {
            var sql = "SELECT * FROM Train WHERE Train_Id =@Train_Id";

            return db.Query<Train>(sql, new { @Train_Id = id }).Single();

        }

        public List<Train> GetTrains()
        {
            var sql = "SELECT * FROM Train";

            return db.Query<Train>(sql).ToList();

        }
        public List<Train> FindWithdate(string date)
        {
            var sql = "SELECT * FROM Train WHERE Date=@Date";
            List<Train> trains = (db.Query<Train>(sql, new { Date = date }).ToList());
            return trains;
             
        }

        public Train InsertingData(Train train)
        {
            var sql = "INSERT INTO Train(Train_Id,Train_Name,Date) VALUES(@Train_Id,@Train_Name,@Date)";
            db.Query<int>(sql, new
            {
                train.Train_Id,
                train.Train_Name,
                train.Date
                
            });
            return train;
        }

        public Train UpdateTrain(Train train)
        {
            var sql = "UPDATE Train SET Train_Id = @Train_Id WHERE Train_Id = @Train_Id ";
              db.Execute(sql, train);
            return train;
        }
        public Train Delete(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
