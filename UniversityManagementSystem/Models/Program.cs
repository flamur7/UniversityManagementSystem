using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
    }
}
