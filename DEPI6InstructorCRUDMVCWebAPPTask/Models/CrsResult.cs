using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}
