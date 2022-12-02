using FinalProject_MattC_GabeP.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_MattC_GabeP.Models.DataLayer
{
    public class MattC_GabePContext : DbContext
    {
        public MattC_GabePContext(DbContextOptions<MattC_GabePContext> options)
            : base(options)
        { }

        public DbSet<FeedbackViewModel> Feedback { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FeedbackConfig());

        }
    }
}
