using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChiTietBCDT
    {
        [Key]
        public int Id { get; set; }

        public int ID_BCDT { get; set; }
        [ForeignKey(nameof(ID_BCDT))]
        public virtual BaoCaoDoanhThu BaoCaoDoanhThu { get; set; }

        public int ID_HieuXe { get; set; }
        [ForeignKey(nameof(ID_HieuXe))]
        public virtual HieuXe HieuXe { get; set; }

        public int SoLuotSua { get; set; }

        public double ThanhTien {  get; set; }

        public float TiLe {  get; set; }
    }
}
