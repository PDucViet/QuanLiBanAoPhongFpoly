using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SuaLaiLanN : Migration
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
                    EmailNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoBNV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaiKhoanNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhauNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_ChucVuId",
                        column: x => x.ChucVuId,
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
                    HoaDonCTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AoPhongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangSXId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatLieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aoPhongCTs", x => x.MaAoPhongCT);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_aoPhongs_AoPhongId",
                        column: x => x.AoPhongId,
                        principalTable: "aoPhongs",
                        principalColumn: "MaAoPhong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_chatLieus_ChatLieuId",
                        column: x => x.ChatLieuId,
                        principalTable: "chatLieus",
                        principalColumn: "MaChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_hangSXes_HangSXId",
                        column: x => x.HangSXId,
                        principalTable: "hangSXes",
                        principalColumn: "MaHSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_maus_MauId",
                        column: x => x.MauId,
                        principalTable: "maus",
                        principalColumn: "MaMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aoPhongCTs_sizes_SizeId",
                        column: x => x.SizeId,
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
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "khachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    MaHdct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AoPhongCTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.MaHdct);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_aoPhongCTs_AoPhongCTId",
                        column: x => x.AoPhongCTId,
                        principalTable: "aoPhongCTs",
                        principalColumn: "MaAoPhongCT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_AoPhongId",
                table: "aoPhongCTs",
                column: "AoPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_ChatLieuId",
                table: "aoPhongCTs",
                column: "ChatLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_HangSXId",
                table: "aoPhongCTs",
                column: "HangSXId");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_MauId",
                table: "aoPhongCTs",
                column: "MauId");

            migrationBuilder.CreateIndex(
                name: "IX_aoPhongCTs_SizeId",
                table: "aoPhongCTs",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_AoPhongCTId",
                table: "hoaDonChiTiets",
                column: "AoPhongCTId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonId",
                table: "hoaDonChiTiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhachHangId",
                table: "hoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienId",
                table: "hoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_ChucVuId",
                table: "nhanViens",
                column: "ChucVuId");
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
