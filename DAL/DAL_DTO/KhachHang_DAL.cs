using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class KhachHang_DAL
    {
        public List<KhachHang> getAllKH()
        {
            CSDL db = new CSDL();
            return db.KhachHangs.ToList();
        }
        public void themKhachHang(KhachHang a)
        {
            CSDL db = new CSDL();
            db.KhachHangs.Add(a);
            db.SaveChanges();
        }
        public KhachHang getKHByID(int id)
        {
            CSDL db = new CSDL();
            return db.KhachHangs.FirstOrDefault(p => p.Id == id);
        }
        public void deleteKhachHang(int Id)
        {
            CSDL db = new CSDL();
            var s = db.KhachHangs.FirstOrDefault(p => p.Id == Id);
            db.KhachHangs.Remove(s);
            db.SaveChanges();
        }
        public void updateKhachHang(KhachHang a)
        {
            CSDL db = new CSDL();
            var s = db.KhachHangs.FirstOrDefault(p => p.Id ==a.Id);
            s.TenChuXe = a.TenChuXe;
            s.DiaChi = a.DiaChi;
            s.SoDienThoai = a.SoDienThoai;
            s.BienSoXe = a.BienSoXe;
            s.Email = a.Email;
            s.HieuXe_ID = a.HieuXe_ID;
            db.SaveChanges();
        }
    }
}
