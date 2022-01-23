using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffRole { get; set; }
        public DataType StartJob { get; set; }
    }
}
