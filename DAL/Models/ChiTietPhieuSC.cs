using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChiTietPhieuSC
    {
        [Key]
        public int Id { get; set; }

        public int ID_Phieu { get; set; }
        [ForeignKey(nameof(ID_Phieu))]
        public virtual PhieuSuaChua PhieuSuaChua { get; set; }

        public int ID_TienCong { get; set; }
        [ForeignKey(nameof(ID_TienCong))]
        public virtual TienCong TienCong { get; set; }
        public bool isDone { get; set; }
        public int ID_PhuTung { get; set; }
        [ForeignKey(nameof(ID_PhuTung))]
        public virtual PhuTung PhuTung { get; set; }
        public double SoLuong { get; set; }
        public double TienUng { get; set; }
        public double Total { get; set; }

    }
}
