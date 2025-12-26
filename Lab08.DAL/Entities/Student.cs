using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.DAL.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } 

        public int Age { get; set; } 

        [StringLength(50)]
        public string Major { get; set; } 
    }
}
