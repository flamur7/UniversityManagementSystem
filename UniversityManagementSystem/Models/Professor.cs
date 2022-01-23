using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorSurname { get; set; }
        public DataType ProfessorJob { get; set; }
        public string ProffessorTitle { get; set; }
    }
}
