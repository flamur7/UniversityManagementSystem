using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [Display(Name = "Grades")]
        public string GradeName { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
