using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class TienCongVM
    {
        public int Id { get; set; }
        [DisplayName("Nội Dung")]
        [Required(ErrorMessage = "Nội Dung không được để trống")]
        public string NoiDung { get; set; }
        [DisplayName("Tiền Công")]
        [Required(ErrorMessage = "Tiền Công không được để trống")]
        public double GiaTC { get; set; }
    }
}
