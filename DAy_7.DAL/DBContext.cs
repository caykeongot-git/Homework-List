using DAy_7.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAy_7.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<CongTy> CongTys { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=DE123;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
