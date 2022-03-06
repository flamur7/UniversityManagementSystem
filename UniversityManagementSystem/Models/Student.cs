using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "Personal Number")]
        public int PersonalNumber { get; set; }

        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }

        public string Surname { get; set; }

        public string Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        
        public string Email { get; set; }
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
