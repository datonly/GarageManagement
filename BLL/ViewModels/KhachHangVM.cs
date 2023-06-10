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
    public class KhachHangVM
    {
        public int Id { get; set; }
        
        [DisplayName("Biển số xe")]
        [Required(ErrorMessage = "Biển số xe không được để trống")]
        public string BienSoXe { get; set; }
        
        //[Browsable(false)]
        public int HieuXe_ID { get; set; }
        
        [DisplayName("Hiệu xe")]
        public string HieuXe { get; set; }
        
        [DisplayName("Tên chủ xe")]
        [Required(ErrorMessage = "Tên chủ xe không được để trống")]
        public string TenChuXe { get; set; }
        [DisplayName("SĐT")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        [MaxLength(10, ErrorMessage = "SĐT không được quá 10 chữ số")]
        [Phone(ErrorMessage = "SĐT phải nhập số")]
        public string SoDienThoai { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string DiaChi { get; set; }
    }
}
