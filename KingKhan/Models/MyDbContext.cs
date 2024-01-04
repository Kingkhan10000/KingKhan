using Microsoft.EntityFrameworkCore;

namespace KingKhan.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> option) : base(option)
        {

        }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }
}
