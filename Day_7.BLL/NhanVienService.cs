using DAy_7.DAL.Entities;
using DAy_7.DAL;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day_7.BLL
{
    public class NhanVienService
    {
        public List<NhanVien> GetAll()
        {
            using (var context = new DBContext())
            {
                return context.NhanViens.Include("CongTy").ToList();
            }
        }

        public List<NhanVien> GetDuongTinh()
        {
            using (var context = new DBContext())
            {
                return context.NhanViens.Include("CongTy")
                              .Where(p => p.AmTinh == false)
                              .ToList();
            }
        }

        public NhanVien FindById(string id)
        {
            using (var context = new DBContext())
            {
                return context.NhanViens.FirstOrDefault(p => p.ID == id);
            }
        }

        public void AddOrUpdate(NhanVien nv)
        {
            using (var context = new DBContext())
            {
                var existNV = context.NhanViens.FirstOrDefault(p => p.ID == nv.ID);

                if (existNV != null)
                {
                    existNV.HoTen = nv.HoTen;
                    existNV.SoLanXN = nv.SoLanXN;
                    existNV.AmTinh = nv.AmTinh;
                    existNV.MaCty = nv.MaCty;
                }
                else
                {
                    context.NhanViens.Add(nv);
                }

                context.SaveChanges();
            }
        }
    }
}