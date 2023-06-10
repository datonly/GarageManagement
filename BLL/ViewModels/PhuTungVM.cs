using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class PhuTungVM
    {
        [DisplayName("Mã VTPT")]
        public int Id { get; set; }
        [DisplayName("Tên VTPT")]
        [Required(ErrorMessage = "Tên VTPT không được để trống")]
        public string NameVTPT { get; set; }
        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị tính không được để trống")]
        public string DonVi { get; set; }


        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public double SoLuong { get; set; }
        [DisplayName("Giá bán")]
        [Required(ErrorMessage = "Giá bán không được để trống")]
        public double GiaBan { get; set; }
    }
}
