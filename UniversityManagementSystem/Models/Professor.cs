using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorSurname { get; set; }
        public string ProffessorTitle { get; set; }
        public string Image { get; set; }

        [Display(Name = "Nationality")]
        public int NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }


    }
}
