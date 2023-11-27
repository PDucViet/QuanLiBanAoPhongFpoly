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
        public Guid HoaDonId { get; set; }
        [ForeignKey("HoaDonId")] public HoaDon HoaDon { get; set; }
        public Guid AoPhongCTId { get; set; }
        [ForeignKey("AoPhongCTId")] public AoPhongCT AoPhongCT { get; set; }
    }
}
