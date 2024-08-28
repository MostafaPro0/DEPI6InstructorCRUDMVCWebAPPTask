using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
