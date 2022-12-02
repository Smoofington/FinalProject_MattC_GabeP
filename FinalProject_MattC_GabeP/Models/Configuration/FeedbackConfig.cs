using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FinalProject_MattC_GabeP.Models.Configuration
{
    internal class FeedbackConfig : IEntityTypeConfiguration<FeedbackViewModel>
    {
        public void Configure(EntityTypeBuilder<FeedbackViewModel> entity)
        {
            entity.HasData(
                new FeedbackViewModel { FeedbackName = "Matt", FeedbackText = "Smells great,tastes great, all things people say about websites." },
                new FeedbackViewModel { FeedbackName = "Gabe", FeedbackText = "Well, we created this so........ it looks good to me." }
                );

            
        }
    }
}
