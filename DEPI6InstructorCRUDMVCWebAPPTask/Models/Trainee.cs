using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI6InstructorCRUDMVCWebAPPTask.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public string Grade { get; set; }

        public ICollection<CrsResult> CrsResults { get; set; }
    }
}
