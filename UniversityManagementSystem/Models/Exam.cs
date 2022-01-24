using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public string Subject { get; set; }

        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [Display(Name = "Program")]
        public int ProgramUniversityId { get; set; }
        [ForeignKey("ProgramUniversityId")]
        public virtual ProgramUniversity ProgramUniversity { get; set; }

        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
