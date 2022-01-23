using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string FeedbackName { get; set; }
        public string FeedbackComment { get; set; }
    }
}
