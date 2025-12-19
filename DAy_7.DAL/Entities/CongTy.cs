using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy_7.DAL.Entities
{
    public class CongTy
    {
        [Key]
        [StringLength(6)]
        public string MaCty { get; set; }

        [Required]
        [StringLength(100)]
        public string TenCty { get; set; } 

        public int SLNV { get; set; } 

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
