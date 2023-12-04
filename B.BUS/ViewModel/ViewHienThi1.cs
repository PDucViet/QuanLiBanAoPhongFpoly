using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.ViewModel
{
    public class ViewHienThi1
    {
        public ChucVu chucVus { get; set; }
        public HangSX hangSXs { get; set; }
        public HoaDonChiTiet hoaDonChiTiets { get; set; }
        public HoaDon hoaDons { get; set; }
        public KhachHang KhachHangs { get; set; }
        public Mau mauSacs { get; set; }
        public NhanVien nhanViens { get; set; }
        public AoPhongCT aoPhongCTs { get; set; }
        public Size sizes { get; set; }
        public AoPhong aoPhongs { get; set; }
    }
}
