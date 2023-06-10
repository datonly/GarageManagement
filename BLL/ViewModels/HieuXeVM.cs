using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class HieuXeVM
    {
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Tên hiệu xe không được để trống")]
        public string NameHieuXe { get; set; }
        
        
        
    }
    
}
