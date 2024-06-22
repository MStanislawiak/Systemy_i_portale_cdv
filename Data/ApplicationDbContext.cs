using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; // Upewnij się, że ta przestrzeń nazw jest poprawna

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
