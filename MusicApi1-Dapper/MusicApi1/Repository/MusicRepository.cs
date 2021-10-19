using Dapper;
using Microsoft.Extensions.Configuration;
using MusicApi1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi1.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private IDbConnection db;

        public MusicRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public Song Find(int id)
        {
            var sql = "SELECT * FROM Songs WHERE S_no =@S-no";
            return db.Query<Song>(sql, new { @S_no = id }).Single();
        }

        public List<Song> Get()
        {
            var sql = "SELECT * FROM Songs";
            return db.Query<Song>(sql).ToList();
            
        }

    }
}