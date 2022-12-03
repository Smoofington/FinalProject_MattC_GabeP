namespace FinalProject_MattC_GabeP.Models.DataLayer
{
    public class FeedbackUnit : IFeedbackUnit
    {
        private MattC_GabePContext _context { get; set; }
        public FeedbackUnit(MattC_GabePContext ctx) => _context = ctx;

        private Repository<FeedbackViewModel> feedbackData;
        public Repository<FeedbackViewModel> Feedback
        {
            get
            {
                if (feedbackData == null)
                    feedbackData = new Repository<FeedbackViewModel>(_context);
                return feedbackData;
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
