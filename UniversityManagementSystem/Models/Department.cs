using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
