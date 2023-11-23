using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class HoaDonChiTiet
    {
        [Key]public Guid MaHdct { get; set; }
        public HoaDon HoaDon { get; set; }
        public Guid MaAoPhongCT { get; set; }
        [ForeignKey("MaAoPhongCT")] public AoPhongCT AoPhongCT { get; set; }
    }
}
