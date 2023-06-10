using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HieuXe
    {
        [Key]
        public int Id { get; set; }
        
        public string NameHieuXe {  get; set; }
        public virtual HashSet<KhachHang> KhachHangs { get; set; }
    }
}
