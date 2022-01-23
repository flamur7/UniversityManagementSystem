using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Nationality
    {
        [Key]
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
