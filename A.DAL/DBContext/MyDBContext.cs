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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QuanLiBanAoPhongDB;Trusted_Connection=True;TrustServerCertificate=True;");
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AoPhongCT>()
                .HasOne(s => s.HoaDonChiTiet)
                .WithOne(s => s.AoPhongCT)
                .HasForeignKey<HoaDonChiTiet>(s => s.AoPhongCTId);
        }
    }
}
