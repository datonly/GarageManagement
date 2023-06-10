using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class ChiTietPhieuSC_DAL
    {
        public List<ChiTietPhieuSC> getAllChiTietPSC()
        {
            CSDL db = new CSDL();
            return db.ChiTietPhieuSCs.ToList();
        }
        public void addCTPSC(ChiTietPhieuSC a)
        {
            CSDL db = new CSDL();
            db.ChiTietPhieuSCs.Add(a);
            db.SaveChanges();
        }
        public void updateCTPSC(ChiTietPhieuSC a)
        {
            CSDL db = new CSDL();
            var s = db.ChiTietPhieuSCs.FirstOrDefault(p => p.Id ==  a.Id);
            s.ID_TienCong = a.ID_TienCong;
            s.ID_PhuTung = a.ID_PhuTung;
            s.SoLuong = a.SoLuong;
            s.TienUng = a.TienUng;
            s.Total = a.Total;
            db.SaveChanges();
        }
        public ChiTietPhieuSC getCTPSCByID(int Id)
        {
            CSDL db = new CSDL();
            return db.ChiTietPhieuSCs.FirstOrDefault(p => p.Id == Id);
        }
        public void updateHoanThanh(int Id)
        {
            CSDL db = new CSDL();
            var s = db.ChiTietPhieuSCs.FirstOrDefault(p => p.Id == Id);
            s.isDone = true;
            db.SaveChanges();
        }
        public void deleteCTPSC(int Id)
        {
            CSDL db = new CSDL();
            var s = db.ChiTietPhieuSCs.FirstOrDefault(p => p.Id == Id);
            db.ChiTietPhieuSCs.Remove(s);
            db.SaveChanges();
        }
    }
}
