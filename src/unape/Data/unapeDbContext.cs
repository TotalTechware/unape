using Microsoft.EntityFrameworkCore;
using unape.Models;

namespace unape.Data
{
    public class unapeDbContext : DbContext
    {
        public unapeDbContext(DbContextOptions<unapeDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
