﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
        public List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}