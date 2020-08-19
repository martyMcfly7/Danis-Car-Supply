using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace finalGroupProject.Models
{
    public class finalGroupProjectContext : DbContext
    {
        public finalGroupProjectContext (DbContextOptions<finalGroupProjectContext> options)
            : base(options)
        {
        }

        public DbSet<finalGroupProject.Models.CarSupply> CarSupply { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // using local SQLite database instead of using SQL Server
            optionsBuilder.UseSqlite("Filename=./Data/CarSupply.db");
        }
    }
}
