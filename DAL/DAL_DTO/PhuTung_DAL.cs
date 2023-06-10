using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class PhuTung_DAL
    {
        public List<PhuTung> getAllPhuTung()
        {
            CSDL db = new CSDL();
            return db.PhuTungs.ToList();
        }
        public void addPhuTung(PhuTung phuTung)
        {
            CSDL db = new CSDL();
            db.PhuTungs.Add(phuTung);
            db.SaveChanges();
        }
        public void UpdateSoLuong(int Id, double SL)
        {
            CSDL db = new CSDL();
            var a = db.PhuTungs.FirstOrDefault(x => x.Id == Id);
            a.SoLuong = SL;
            db.SaveChanges();
        }
        public void UpdatePhuTung(PhuTung a)
        {
            CSDL db = new CSDL();
            var s = db.PhuTungs.FirstOrDefault(p => p.Id == a.Id);
            s.NameVTPT = a.NameVTPT;
            s.DonVi = a.DonVi;
            s.GiaBan = a.GiaBan;
            db.SaveChanges();
        }
        public void deletePhuTung(int Id)
        {
            CSDL db = new CSDL();
            var s = db.PhuTungs.FirstOrDefault(p => p.Id == Id);
            s.isDeleted = true;
            db.SaveChanges();
        }
    }
}
