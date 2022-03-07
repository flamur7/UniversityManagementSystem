using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Display(Name ="Full name")]
        public string StaffName { get; set; }

        [Display(Name = "Role")]
        public string StaffRole { get; set; }
        public string Image { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        [Display(Name = "Started Job")]
        [DataType(DataType.Date)]
        public DateTime StaredJob { get; set; }

        [Display(Name = "Branch Work")]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [Display(Name = "Nationality")]
        public int NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
