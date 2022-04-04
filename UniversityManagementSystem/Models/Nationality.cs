using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Nationality
    {
        [Key]
        public int NationalityId { get; set; }

        [Display(Name = "Nationality")]
        public string NationalityName { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        
    }
}
