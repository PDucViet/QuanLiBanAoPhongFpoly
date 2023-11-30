using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid HoaDonCTId { get; set; }
        [ForeignKey("HoaDonCTId")]public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public Guid AoPhongId { get; set; }
        [ForeignKey("AoPhongId")] public AoPhong AoPhong { get; set; }
        public Guid SizeId { get; set; }
        [ForeignKey("SizeId")] public Size Size { get; set; }
        public Guid MauId { get; set; }
        [ForeignKey("MauId")] public Mau Mau { get; set; }
        public Guid HangSXId { get; set; }
        [ForeignKey("HangSXId")] public HangSX HangSX { get; set; }
        public Guid ChatLieuId { get; set; }
        [ForeignKey("ChatLieuId")] public ChatLieu ChatLieu { get; set; }
    }
}
