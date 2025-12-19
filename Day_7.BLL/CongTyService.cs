using DAy_7.DAL;
using DAy_7.DAL.Entities;
using DAy_7.DAL.Entities;
using System.Collections.Generic;
using System.Linq;


namespace Day_7.BLL
{
    public class CongTyService
    {
        public List<CongTy> GetAll()
        {
            using (var context = new DBContext())
            {
                return context.CongTys.ToList();
            }
        }

        public List<CongTy> GetCongTyDuYeuCau()
        {
            using (var context = new DBContext())
            {
                return context.CongTys
                              .Where(c => c.NhanViens.Count() >= c.SLNV)
                              .ToList();
            }
        }
    }
}