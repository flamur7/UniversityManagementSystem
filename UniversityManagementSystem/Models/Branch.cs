﻿using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }

    }
}
