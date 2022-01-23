using System.ComponentModel.DataAnnotations;

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

        public DataType Birthday { get; set; }
        public string Birthplace { get; set; }

    }
}
