using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Nationality> Nationalitys { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<ProgramUniversity> ProgramUniversity { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TodoItem> TodoItems { get; set; }
        public virtual DbSet<Bills> Billss { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
