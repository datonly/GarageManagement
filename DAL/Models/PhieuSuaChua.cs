using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PhieuSuaChua
    {
        [Key]
        public int Id { get; set; }

        public string BillCode { get; set; }
        public virtual HashSet<ChiTietPhieuSC> ChiTietPhieuSCs { get; set; }

        public int Customer_ID { get; set; }
        [ForeignKey(nameof(Customer_ID))]
        public virtual KhachHang KhachHang { get; set; }

        public DateTime NgayLapPhieu { get; set; }

        public DateTime? NgayThanhToan {  get; set; }

        public int Account_ID { get; set; }
        [ForeignKey(nameof(Account_ID))]
        public virtual AccountInformation Cashier { get; set; }

        public double TienUng {  get; set; }

        public double TongTien { get; set; }

        public string TrangThai { get; set; }

        public string GhiChu { get; set; }


    }
}
