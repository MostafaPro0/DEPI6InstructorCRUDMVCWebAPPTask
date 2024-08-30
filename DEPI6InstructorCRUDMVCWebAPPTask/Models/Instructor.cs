using Microsoft.AspNetCore.Mvc;
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

        [Required(ErrorMessage = "Name Is Required!!")]
        [MaxLength(50, ErrorMessage = "Max Length Of Name 50 Chars")]
        [MinLength(5, ErrorMessage = "Min Length Of Name 50 Chars")]
        [Remote(action: "VerifyExistInstructor", controller: "Instructor")]
        public string Name { get; set; }
        public string Img { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1000,100000)]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Address Is Required!!")]
        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$"
                          , ErrorMessage = "Address must be like 123-Streat-City-Country")]
        public string Address { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Course>? Courses { get; set; }
    }
}
