using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class HoaDonChiTiet
    {
        [Key]public Guid MaHdct { get; set; }
        public bool TrangThaiHdct { get; set; }
        public HoaDon HoaDon { get; set; }
        public AoPhongCT AoPhongCT { get; set; }
    }
}
