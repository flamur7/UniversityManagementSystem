using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        [DataType(DataType.Date)]
        public DataType ExamDay { get; set; }
        public string Subject { get; set; }
    }
}
