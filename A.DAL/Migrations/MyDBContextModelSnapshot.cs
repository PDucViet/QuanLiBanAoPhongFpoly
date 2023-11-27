﻿// <auto-generated />
using System;
using A.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A.DAL.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("A.DAL.Models.AoPhong", b =>
                {
                    b.Property<Guid>("MaAoPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenAoPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThaiAoPhong")
                        .HasColumnType("bit");

                    b.HasKey("MaAoPhong");

                    b.ToTable("aoPhongs");
                });

            modelBuilder.Entity("A.DAL.Models.AoPhongCT", b =>
                {
                    b.Property<Guid>("MaAoPhongCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AoPhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatLieuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<double>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<Guid>("HangSXId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonCTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThaiAoPhongCT")
                        .HasColumnType("bit");

                    b.HasKey("MaAoPhongCT");

                    b.HasIndex("AoPhongId");

                    b.HasIndex("ChatLieuId");

                    b.HasIndex("HangSXId");

                    b.HasIndex("MauId");

                    b.HasIndex("SizeId");

                    b.ToTable("aoPhongCTs");
                });

            modelBuilder.Entity("A.DAL.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("MaChatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThaiChatLieu")
                        .HasColumnType("bit");

                    b.HasKey("MaChatLieu");

                    b.ToTable("chatLieus");
                });

            modelBuilder.Entity("A.DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("MaChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChucVu");

                    b.ToTable("chucVus");
                });

            modelBuilder.Entity("A.DAL.Models.HangSX", b =>
                {
                    b.Property<Guid>("MaHSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThaiHSX")
                        .HasColumnType("bit");

                    b.HasKey("MaHSX");

                    b.ToTable("hangSXes");
                });

            modelBuilder.Entity("A.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<Guid>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTT")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.HasKey("MaHD");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("A.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("MaHdct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AoPhongCTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaHdct");

                    b.HasIndex("AoPhongCTId")
                        .IsUnique();

                    b.HasIndex("HoaDonId");

                    b.ToTable("hoaDonChiTiets");
                });

            modelBuilder.Entity("A.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinhKH")
                        .HasColumnType("bit");

                    b.Property<string>("SdtKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKH");

                    b.ToTable("khachHangs");
                });

            modelBuilder.Entity("A.DAL.Models.Mau", b =>
                {
                    b.Property<Guid>("MaMau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThaiMu")
                        .HasColumnType("bit");

                    b.HasKey("MaMau");

                    b.ToTable("maus");
                });

            modelBuilder.Entity("A.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("MaNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChucVuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoBNV")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinhNV")
                        .HasColumnType("bit");

                    b.Property<string>("MatKhauNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SdtNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoanNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaNV");

                    b.HasIndex("ChucVuId");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("A.DAL.Models.Size", b =>
                {
                    b.Property<Guid>("MaSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThaiSize")
                        .HasColumnType("bit");

                    b.HasKey("MaSize");

                    b.ToTable("sizes");
                });

            modelBuilder.Entity("A.DAL.Models.AoPhongCT", b =>
                {
                    b.HasOne("A.DAL.Models.AoPhong", "AoPhong")
                        .WithMany("AoPhongCT")
                        .HasForeignKey("AoPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.ChatLieu", "ChatLieu")
                        .WithMany("AoPhongCT")
                        .HasForeignKey("ChatLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.HangSX", "HangSX")
                        .WithMany("AoPhongCT")
                        .HasForeignKey("HangSXId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.Mau", "Mau")
                        .WithMany("AoPhongCT")
                        .HasForeignKey("MauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.Size", "Size")
                        .WithMany("AoPhongCT")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AoPhong");

                    b.Navigation("ChatLieu");

                    b.Navigation("HangSX");

                    b.Navigation("Mau");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("A.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("A.DAL.Models.KhachHang", "KhachHang")
                        .WithMany("hoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("hoaDons")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("A.DAL.Models.AoPhongCT", "AoPhongCT")
                        .WithOne("HoaDonChiTiet")
                        .HasForeignKey("A.DAL.Models.HoaDonChiTiet", "AoPhongCTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A.DAL.Models.HoaDon", "HoaDon")
                        .WithMany("hoaDonChiTiets")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AoPhongCT");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("A.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("A.DAL.Models.ChucVu", "ChucVu")
                        .WithMany("NhanVien")
                        .HasForeignKey("ChucVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("A.DAL.Models.AoPhong", b =>
                {
                    b.Navigation("AoPhongCT");
                });

            modelBuilder.Entity("A.DAL.Models.AoPhongCT", b =>
                {
                    b.Navigation("HoaDonChiTiet")
                        .IsRequired();
                });

            modelBuilder.Entity("A.DAL.Models.ChatLieu", b =>
                {
                    b.Navigation("AoPhongCT");
                });

            modelBuilder.Entity("A.DAL.Models.ChucVu", b =>
                {
                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("A.DAL.Models.HangSX", b =>
                {
                    b.Navigation("AoPhongCT");
                });

            modelBuilder.Entity("A.DAL.Models.HoaDon", b =>
                {
                    b.Navigation("hoaDonChiTiets");
                });

            modelBuilder.Entity("A.DAL.Models.KhachHang", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("A.DAL.Models.Mau", b =>
                {
                    b.Navigation("AoPhongCT");
                });

            modelBuilder.Entity("A.DAL.Models.NhanVien", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("A.DAL.Models.Size", b =>
                {
                    b.Navigation("AoPhongCT");
                });
#pragma warning restore 612, 618
        }
    }
}
