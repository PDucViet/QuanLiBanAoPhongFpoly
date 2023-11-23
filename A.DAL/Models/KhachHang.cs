using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class KhachHang
    {
        [Key] public Guid MaKH {  get; set; }
        public string TenKH { get; set; }
        public string SdtKH { get; set; }
        public string DiaChiKH { get; set; }
        public bool GioiTinhKH { get; set; }
        public List<HoaDon>hoaDons { get; set; }
    }
}
