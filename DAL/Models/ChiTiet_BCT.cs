using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChiTiet_BCT
    {
        [Key]
        public int Id { get; set; }

        public int BCT_ID { get; set; }
        [ForeignKey(nameof(BCT_ID))]
        public virtual BaoCaoTonVTPT BaoCaoTonVTPT { get; set; }

        public int VTPT_ID { get; set; }
        [ForeignKey(nameof(VTPT_ID))]
        public virtual PhuTung PhuTung { get; set; }

        public int TonDau { get; set; }

        public int PhatSinh { get; set; }

        public int TonCuoi { get; set; }
    }
}
