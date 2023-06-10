using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class PhieuSuaChuaVM
    {
        public int Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        [Required(ErrorMessage = "Mã hoá đơn không được để trống")]
        
        public string BillCode { get; set; }

        [Browsable(false)]
        public int Customer_ID { get; set; }
        [DisplayName("Tên khách hàng")]
        public string Customer_Name { get; set; }
        [DisplayName("Biển số xe")]
        public string BienSoXe { get; set; }
        [DisplayName("SĐT")]
        public string Customer_Phone { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime NgayLapPhieu { get; set; }
        [DisplayName("Ngày thanh toán")]
        public DateTime? NgayThanhToan { get; set; }
        [Browsable(false)]
        public int Account_ID { get; set; }
        [DisplayName("Tên thu ngân")]
        public string Cashier_Name { get; set; }
        [DisplayName("Đã ứng")]
        public double TienUng { get; set; }
        [DisplayName("Tổng tiền")]
        public double TongTien { get; set; }
        
    }
}
