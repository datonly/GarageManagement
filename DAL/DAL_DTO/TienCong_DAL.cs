using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_DTO
{
    public class TienCong_DAL
    {
        public List<TienCong> getAllTienCong()
        {
            CSDL db = new CSDL();
            return db.TienCongs.ToList();
        }
        public void addTienCong(TienCong tc)
        {
            CSDL db = new CSDL();
            db.TienCongs.Add(tc);
            db.SaveChanges();
        }
        public void UpdateTienCong(TienCong tc)
        {
            CSDL db = new CSDL();
            var s = db.TienCongs.FirstOrDefault(p => p.Id == tc.Id);
            s.NoiDung = tc.NoiDung;
            s.GiaTC = tc.GiaTC;
            db.SaveChanges();
        }
    }
}
