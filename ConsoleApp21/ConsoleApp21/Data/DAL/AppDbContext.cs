using ConsoleApp21.Data.Entities;
using System.Data.Entity;

namespace ConsoleApp21.Data.DAL
{
    class AppDbContext:DbContext
    {
        public object Stadions { get; set; }

        protected override void OnConFiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=215-17;Database=FootBall;Trusted_Connection=True");
        }

        public DbSet<Stadions> Stadions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}

