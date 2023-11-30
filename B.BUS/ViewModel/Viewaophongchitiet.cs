using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.ViewModel
{
    public class Viewaophongchitiet
    {
        public ChucVu chucVus { get; set; }
        public HangSX hangSXes { get; set; }
        public HoaDonChiTiet hoaDonChiTiets { get; set; }
        public HoaDon hoaDons { get; set; }
        public KhachHang khachHangs { get; set; }
        public Mau maus { get; set; }
        public NhanVien nhanViens { get; set; }
        public AoPhongCT aoPhongCTs { get; set; }
        public Size sizes { get; set; }
        public AoPhong aoPhongs { get; set; }
        public ChatLieu chatLieus { get; set; }
    }
}
