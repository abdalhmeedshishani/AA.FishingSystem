using Microsoft.EntityFrameworkCore;

namespace AA.FishingSystem.EntityFrameworkCore
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<>    { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

         

    }
}