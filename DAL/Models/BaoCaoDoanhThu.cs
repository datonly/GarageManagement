using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BaoCaoDoanhThu
    {
        [Key]
        public int Id { get; set; }

        public int Thang { get; set; }

        public int Nam { get; set; }

        public double TongDoanhThu { get; set; }

        public virtual HashSet<ChiTietBCDT> ChiTietBCDTs { get; set; }
    }
}
