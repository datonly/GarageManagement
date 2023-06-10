using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }

        public string BienSoXe { get; set; }

        public int HieuXe_ID { get; set; }
        [ForeignKey(nameof(HieuXe_ID))]
        public virtual HieuXe HieuXe { get; set; }
        public string TenChuXe { get; set; }

        public string SoDienThoai { get; set; }

        public string Email {  get; set; }

        public string DiaChi { get; set; }

        public virtual HashSet<PhieuSuaChua> PhieuSuaChuas { get; set; }
    }
}
