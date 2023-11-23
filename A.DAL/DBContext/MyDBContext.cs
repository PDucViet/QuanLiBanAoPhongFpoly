using A.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.DBContext
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ChucVu>chucVus { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<HoaDonChiTiet>hoaDonChiTiets { get; set; }
        public DbSet<AoPhongCT>aoPhongCTs { get; set; }
        public DbSet<AoPhong> aoPhongs { get; set; }
        public DbSet<HangSX>hangSXes { get; set; }
        public DbSet<ChatLieu> chatLieus { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Mau> maus { get; set; }
    }
}
