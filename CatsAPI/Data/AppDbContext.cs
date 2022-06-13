using CatsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CatsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Cat> Cats { get; set; }
    }
}