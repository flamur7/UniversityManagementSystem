using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    }
}
