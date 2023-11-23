using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class AoPhongCT
    {
        [Key] public Guid MaAoPhongCT { get; set; }
        public int SoLuong { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }
        public bool TrangThaiAoPhongCT { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public AoPhong AoPhong { get; set; }
        public Size Size { get; set; }
        public Mau Mau { get; set; }
        public HangSX HangSX { get; set; }
        public ChatLieu ChatLieu { get; set; }
    }
}
