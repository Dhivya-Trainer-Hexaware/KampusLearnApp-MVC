using Microsoft.EntityFrameworkCore;

namespace KampusLearnApp_MVC.Models
{
    public class KampusLearnDbContext:DbContext
    {
        //Constructor 
        public KampusLearnDbContext(DbContextOptions<KampusLearnDbContext> options):base(options)
        {
            //The DbContext to do the task it needs  DBContext OPtions instance. This instance carries configuration info such as Connection string, database provider.
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Batch> Batches { get; set; }

        //OnConfiguring - For configuring the Connection string and to configure the provider  UseSqlServer()

        // optionsBuilder.UseSqlServer("server=.....;Database=...........;integrated sec=true");

    }
}
