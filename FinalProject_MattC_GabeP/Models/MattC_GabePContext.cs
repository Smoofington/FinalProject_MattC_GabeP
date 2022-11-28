using Microsoft.EntityFrameworkCore;

namespace FinalProject_MattC_GabeP.Models
{
    public class MattC_GabePContext : DbContext
    {
        public MattC_GabePContext(DbContextOptions<MattC_GabePContext> options)
            : base(options)
        { }

        //public DbSet<Day> Days { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DayConfig());
            //modelBuilder.ApplyConfiguration(new TeacherConfig());
            //modelBuilder.ApplyConfiguration(new ClassConfig());
        }
    }
}
