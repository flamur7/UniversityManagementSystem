using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Assessment
    {
        [Key]
        public int AssessmentId { get; set; }

        public int StudentCode { get; set; }
        public string FullName { get; set; }


        [Display(Name = "Exam")]
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        [Display(Name = "Grade")]
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public virtual Grade Grade { get; set; }
    }
}
