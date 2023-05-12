using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players.Models
{
    public class PlayerContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }  


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PlayerDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
