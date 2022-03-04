using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int PersonalNumber { get; set; }
        public string StudentName { get; set; }
        public string ParentName { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }

        public string Birthplace { get; set; }
        [Display(Name = "Program")]
        public int ProgramUniversityId { get; set; }
        [ForeignKey("ProgramUniversityId")]
        public virtual ProgramUniversity ProgramUniversity { get; set; }


        [Display(Name = "Nationality")]
        public int NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }


        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

    }
}
