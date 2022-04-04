using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }

        [Display(Name = "Branches")]
        public string BranchName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }

    }
}
