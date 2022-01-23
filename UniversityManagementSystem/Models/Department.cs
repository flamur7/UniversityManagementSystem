using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        [Display(Name = "Staff")]
        public int StaffId { get; set; }
        [ForeignKey("StaffId")]
        public virtual Staff Staf { get; set; }
    }
}
