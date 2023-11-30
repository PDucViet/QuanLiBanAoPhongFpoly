using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class HoaDon
    {
        [Key]public Guid MaHD {  get; set; }
        public DateTime NgayBan { get; set; }
        public DateTime NgayTT { get; set; }
        public double GiamGia { get; set; }
        public double TongTien {  get; set; }
        public string GhiChu { get; set; }
        public Guid NhanVienId { get; set; }
        [ForeignKey("NhanVienId")] public NhanVien NhanVien { get; set; }
        public Guid KhachHangId { get; set; }
        [ForeignKey("KhachHangId")] public KhachHang KhachHang { get; set; }
        public List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
