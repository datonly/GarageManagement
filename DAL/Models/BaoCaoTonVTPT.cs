using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BaoCaoTonVTPT
    {
        [Key]
        public int Id {  get; set; }

        public int Thang {  get; set; }

        public int Nam { get; set; }

        public virtual HashSet<ChiTiet_BCT> ChiTiet_BCTs { get; set; }

    }
}
