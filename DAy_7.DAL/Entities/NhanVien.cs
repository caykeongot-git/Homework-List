using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy_7.DAL.Entities
{
    public class NhanVien
    {
        [Key]
        [StringLength(12)]
        public string ID { get; set; }  

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }  

        public int SoLanXN { get; set; }  

        public bool AmTinh { get; set; }  

        [StringLength(6)]
        public string MaCty { get; set; } 

        [ForeignKey("MaCty")]
        public virtual CongTy CongTy { get; set; }
    }
}
