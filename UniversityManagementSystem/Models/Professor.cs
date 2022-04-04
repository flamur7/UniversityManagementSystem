using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string ProfessorFullName { get;}
        public string ProffessorTitle { get; set; }

        [Display(Name = "Started Job")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StaredJob { get; set; }
        public string Image { get; set; }

        [Display(Name = "Program")]
        public int ProgramUniversityId { get; set; }
        [ForeignKey("ProgramUniversityId")]
        public virtual ProgramUniversity ProgramUniversity { get; set; }

        [Display(Name = "Nationality")]
        public int NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }


    }
}
