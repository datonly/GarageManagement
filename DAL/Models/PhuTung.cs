using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PhuTung
    {
        [Key]
        public int Id { get; set; }

        public string NameVTPT { get; set; }

        public string DonVi {  get; set; }

        public bool isDeleted { get; set; }

        public double SoLuong { get; set; }

        public double GiaBan { get; set; }

        public virtual HashSet<ChiTietPhieuSC> ChiTietPhieuSCs { get; set; }
    }
}
