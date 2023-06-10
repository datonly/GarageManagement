using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class PhieuSuaChua_DAL
    {
        public List<PhieuSuaChua> getAllPSC()
        {
            CSDL db = new CSDL();
            return db.PhieuSuaChuas.ToList();
        }
        public void addPSC(PhieuSuaChua a)
        {
            CSDL db = new CSDL();
            db.PhieuSuaChuas.Add(a);
            db.SaveChanges();
        }
        public PhieuSuaChua getPSCbyID(int id)
        {
            CSDL db = new CSDL();
            return db.PhieuSuaChuas.FirstOrDefault(p => p.Id == id);
        }
        public void setBillTotal(int Id, double total, double deposit)
        {
            CSDL db = new CSDL();
            var s = db.PhieuSuaChuas.FirstOrDefault(p => p.Id == Id);
            s.TongTien = total;
            s.TienUng = deposit;
            db.SaveChanges();
        }
        public void PurchaseBill(int Id)
        {
            CSDL db = new CSDL();
            var s = db.PhieuSuaChuas.FirstOrDefault(p => p.Id ==Id);
            s.TrangThai = "Purchased";
            s.NgayThanhToan = DateTime.Now;
            db.SaveChanges();
        }
        public void deleteBill(int Id)
        {
            CSDL db = new CSDL();
            var s = db.PhieuSuaChuas.FirstOrDefault(p => p.Id == Id);
            db.PhieuSuaChuas.Remove(s);
            db.SaveChanges();
        }
        
    }
}
