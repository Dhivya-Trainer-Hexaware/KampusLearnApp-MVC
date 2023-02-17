using Microsoft.EntityFrameworkCore;

namespace KampusLearnApp_MVC.Models
{
    public class KampusLearnDbContext:DbContext
    {
        public KampusLearnDbContext(DbContextOptions<KampusLearnDbContext> options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Batch> Batches { get; set; }

        //OnConfiguring - For configuring the Connection string and to configure the provider  UseSqlServer()

        // optionsBuilder.UseSqlServer("server=.....;Database=...........;integrated sec=true");

    }
}
