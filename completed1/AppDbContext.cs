using Microsoft.EntityFrameworkCore;

namespace completed1
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<StringItem> StringItems { get; set; }

    }
}