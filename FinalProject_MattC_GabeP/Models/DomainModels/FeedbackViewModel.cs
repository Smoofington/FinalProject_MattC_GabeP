using System.ComponentModel.DataAnnotations;

namespace FinalProject_MattC_GabeP.Models
{
    public class FeedbackViewModel
    {
        [Key]
        public int FeedbackId { get; set; }        // pk

        [Required(ErrorMessage = "Please enter a title for your feedback.")]
        public string FeedbackName { get; set; }

        [Required(ErrorMessage = "Feedback description must not be empty.")]
        public string FeedbackText { get; set; }
    }
}
