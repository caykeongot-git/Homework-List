using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day_6
{
    public class Student
    {
        [Key] public string Id { get; set; }
        [Required][MaxLength(100)] public string Name { get; set; }
        [Required][MaxLength(50)] public string Faculty { get; set; }
        public double Average { get; set; }
    }
}
