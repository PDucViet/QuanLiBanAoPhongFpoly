using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class NhanVien
    {
        [Key] public Guid MaNV { get; set; }
        public string TenNV { get; set; }
        public bool GioiTinhNV { get; set; }
        public string DiaChiNV { get; set; }
        public string SdtNV { get; set; }
        public DateTime DoBNV { get; set; }
        public string TaiKhoanNV { get; set; }
        public string MatKhauNV { get; set; }
        public bool TrangThaiNV { get; set; }
        public ChucVu ChucVu { get; set; }
        public List<HoaDon> hoaDons { get; set; }
    }
}
