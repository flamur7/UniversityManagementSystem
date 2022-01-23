using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class ProgramUniversity
    {
        [Key]
        public int ProgramUniversityId { get; set; }
        public string ProgramUniversityName { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
