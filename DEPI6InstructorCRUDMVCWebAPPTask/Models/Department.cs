using DEPI6InstructorCRUDMVCWebAPPTask.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Models
{
    public class Department
    {
        public int Id { get; set; }
        [UniqueValidation("Name")]
        public string Name { get; set; }
        public string ManagerName { get; set; }

        public ICollection<Instructor>? Instructors { get; set; }
    }
}

