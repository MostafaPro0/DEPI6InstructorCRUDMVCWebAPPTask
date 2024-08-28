using DEPI6InstructorCRUDMVCWebAPPTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPI6InstructorCRUDMVCWebAPPTask;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Contexts
{
    public class InstructorCRUDMVCAppDbContext:DbContext 
    {

        public InstructorCRUDMVCAppDbContext()
        {

        }
        public InstructorCRUDMVCAppDbContext(DbContextOptions<InstructorCRUDMVCAppDbContext>options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB; Database=InstructorCRUDMVCApp;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
