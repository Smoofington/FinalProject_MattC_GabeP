namespace FinalProject_MattC_GabeP.Models.DataLayer
{
    public interface IFeedbackUnit
    {
        public Repository<FeedbackViewModel> Feedback { get; }

        public void Save();
    }
}
