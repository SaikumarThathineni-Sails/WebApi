using Microsoft.EntityFrameworkCore;
using MusicApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi1.Data
{
    
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base (options) 
        {

        }
        public DbSet<Song> Songs { get; set; }
    }
}
