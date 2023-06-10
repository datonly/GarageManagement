using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class HieuXe_DAL
    {
        public List<HieuXe> getAllHieuXe()
        {
            CSDL db = new CSDL();
            return db.HieuXes.ToList();
        }
        public void themHieuXe(HieuXe hx)
        {
            CSDL db = new CSDL();
            db.HieuXes.Add(hx);
            db.SaveChanges();
        }
        public void xoaHieuXe(int id)
        {
            CSDL db = new CSDL();
            var a = db.HieuXes.Where(p => p.Id == id).FirstOrDefault();
            db.HieuXes.Remove(a);
            db.SaveChanges();
        }
    }
}
