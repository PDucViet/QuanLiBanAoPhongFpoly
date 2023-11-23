using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddMyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aoPhongs",
                columns: table => new
                {
                    MaAoPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenAoPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiAoPhong = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aoPhongs", x => x.MaAoPhong);
                });

            migrationBuilder.CreateTable(
                name: "chatLieus",
                columns: table => new
                {
                    MaChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiChatLieu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieus", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    MaChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "hangSXes",
                columns: table => new
                {
                    MaHSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHSX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiHSX = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSXes", x => x.MaHSX);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SdtKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinhKH = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "maus",
                columns: table => new
                {
                    MaMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiMu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maus", x => x.MaMau);
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiSize = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinhNV = table.Column<bool>(type: "bit", nullable: false),
                    DiaChiNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SdtNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoBNV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaiKhoanNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhauNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVuMaChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_ChucVuMaChucVu",
                        column: x => x.ChucVuMaChucVu,
                        principalTable: "chucVus",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aoPhongCTs",
                columns: table => new
                {
                    MaAoPhongCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<double>(type: "float", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    TrangThaiAoPhongCT = table.Column<bool>(type: "bit", nullable: false),
                    AoPhongMaAoPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeMaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauMaMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangSXMaHSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatLieuMaChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aoPhongCTs", x => x.MaAoPhongCT);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_aoPhongs_AoPhongMaAoPhong",
                        column: x => x.AoPhongMaAoPhong,
                        principalTable: "aoPhongs",
                        principalColumn: "MaAoPhong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_chatLieus_ChatLieuMaChatLieu",
                        column: x => x.ChatLieuMaChatLieu,
                        principalTable: "chatLieus",
                        principalColumn: "MaChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_hangSXes_HangSXMaHSX",
                        column: x => x.HangSXMaHSX,
                        principalTable: "hangSXes",
                        principalColumn: "MaHSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_maus_MauMaMau",
                        column: x => x.MauMaMau,
                        principalTable: "maus",
                        principalColumn: "MaMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_sizes_SizeMaSize",
                        column: x => x.SizeMaSize,
                        principalTable: "sizes",
                        principalColumn: "MaSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    MaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    NhanVienMaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangMaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_KhachHangMaKH",
                        column: x => x.KhachHangMaKH,
                        principalTable: "khachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "nhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    MaHdct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonMaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaAoPhongCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.MaHdct);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_aoPhongCTs_MaAoPhongCT",
                        column: x => x.MaAoPhongCT,
                        principalTable: "aoPhongCTs",
                        principalColumn: "MaAoPhongCT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonMaHD",
                        column: x => x.HoaDonMaHD,
                        principalTable: "hoaDons",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_AoPhongMaAoPhong",
                table: "aoPhongCTs",
                column: "AoPhongMaAoPhong");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_ChatLieuMaChatLieu",
                table: "aoPhongCTs",
                column: "ChatLieuMaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_HangSXMaHSX",
                table: "aoPhongCTs",
                column: "HangSXMaHSX");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_MauMaMau",
                table: "aoPhongCTs",
                column: "MauMaMau");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_SizeMaSize",
                table: "aoPhongCTs",
                column: "SizeMaSize");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonMaHD",
                table: "hoaDonChiTiets",
                column: "HoaDonMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MaAoPhongCT",
                table: "hoaDonChiTiets",
                column: "MaAoPhongCT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhachHangMaKH",
                table: "hoaDons",
                column: "KhachHangMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienMaNV",
                table: "hoaDons",
                column: "NhanVienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_ChucVuMaChucVu",
                table: "nhanViens",
                column: "ChucVuMaChucVu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "aoPhongCTs");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "aoPhongs");

            migrationBuilder.DropTable(
                name: "chatLieus");

            migrationBuilder.DropTable(
                name: "hangSXes");

            migrationBuilder.DropTable(
                name: "maus");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "chucVus");
        }
    }
}
