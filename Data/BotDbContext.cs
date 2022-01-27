global using Microsoft.EntityFrameworkCore;
using Ilmhub.Clients;

namespace Ilmhub.Data
{
    public class BotDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public BotDbContext(DbContextOptions<BotDbContext> options)
            : base(options) { }

    }
}