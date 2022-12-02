using System.ComponentModel.DataAnnotations;

namespace FinalProject_MattC_GabeP.Models
{
    public class FeedbackViewModel
    {
        [Key]
        public int FeedbackId { get; set; }
        public string FeedbackName { get; set; }
        public string FeedbackText { get; set; }
    }
}
