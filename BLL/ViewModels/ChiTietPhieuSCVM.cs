using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class ChiTietPhieuSCVM
    {
        public int Id { get; set; }
        [Browsable(false)]
        public int ID_Phieu { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        public int ID_TienCong { get; set; }
        [DisplayName("Nội Dung")]
        public string NoiDung { get; set; }
        
        
        public int ID_PhuTung { get; set; }
        [DisplayName("Tên VTPT")]
        
        public string TenVTPT { get; set; }
        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public double SoLuong { get; set; }
        [DisplayName("Tiền Ứng")]
        public double TienUng { get; set; }
        [DisplayName("Tổng tiền")]
        public double Total { get; set; }
        [DisplayName("Hoàn thành?")]
        public bool isDone { get; set; }
    }
}
