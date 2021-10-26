using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TrainApi.Models;
using Dapper;

namespace TrainApi.Repository
{
    public class StationRepository : IStationRepository
    {
        private readonly IDbConnection db;


        public StationRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }



        public Station FindStation(int id)
        {
            var sql = "SELECT * FROM Station WHERE S_Id =@S_Id";

            return db.Query<Station>(sql, new { @S_Id = id }).Single();

        }

        public List<Station> GetStations()
        {
            var sql = "SELECT * FROM Station";

            return db.Query<Station>(sql).ToList();

        }

        public Station InsertingData(Station station)
        {
            var sql = "INSERT INTO Station(S_Id,S_Name,Train_Id) VALUES(@S_Id,@S_Name,@Train_Id)";
            db.Query<int>(sql, new
            {
                station.Train_Id,
                station.S_Name,
                station.S_Id

            });
            return station;
        }

        public Station UpdateStation(Station station)
        {
            var sql = "UPDATE Station SET S_Name = @S_Name WHERE S_Id = @S_Id ";
            db.Execute(sql, station);
            return station;
        }
        public Station Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}

