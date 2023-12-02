using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.PL.Forms
{
    public partial class FrmGioHang : Form
    {
        IAoPhongServices _aoPhongServices;
        IHoaDonChiTietServices _hoaDonChiTietServices;
        IKhachHangServices _khachHangServices;
        IAophongchitietServices _aophongchitietServices;
        HoaDonChiTiet hoaDonChiTiet;
        AoPhongCT aoPhongCT;
        KhachHang khachHang;
        AoPhong aoPhong;

        public FrmGioHang()
        {
            InitializeComponent();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _khachHangServices = new KhachHangServices();
            _aophongchitietServices = new AophongchitietServices();
            _aoPhongServices = new AoPhongServices();
            hoaDonChiTiet = new HoaDonChiTiet();
            khachHang = new KhachHang();
            aoPhong = new AoPhong();
            loadDuLieu();
        }
        public void loadDuLieu()
        {
            dgvDanhSachSp.Rows.Clear();
            dgvDanhSachSp.ColumnCount = 10;
            dgvDanhSachSp.Columns[0].Name = "Mã Áo Phông";
            dgvDanhSachSp.Columns[1].Name = "Tên Áo Phông";
            dgvDanhSachSp.Columns[2].Name = "Giá Nhập";
            dgvDanhSachSp.Columns[3].Name = "Giá Bán";
            dgvDanhSachSp.Columns[4].Name = "Số Lượng";
            dgvDanhSachSp.Columns[5].Name = "Màu Sắc";
            dgvDanhSachSp.Columns[6].Name = "Size";
            dgvDanhSachSp.Columns[7].Name = "HangSX";
            dgvDanhSachSp.Columns[8].Name = "Chất liệu";
            dgvDanhSachSp.Columns[9].Name = "Trạng Thái Áo Phông CT";
            dgvDanhSachSp.Columns[0].Width = 10;
            foreach (var item in _aophongchitietServices.getViewAophongCT())
            {
                dgvDanhSachSp.Rows.Add(
                    item.aoPhongCTs.MaAoPhongCT,
                    item.aoPhongs.TenAoPhong,
                    item.aoPhongCTs.GiaNhap,
                    item.aoPhongCTs.GiaBan,
                    item.aoPhongCTs.SoLuong,
                    item.maus.TenMau,
                    item.sizes.TenSize,
                    item.hangSXes.TenHSX,
                    item.chatLieus.TenChatLieu,
                    item.aoPhongCTs.TrangThaiAoPhongCT == true ? "Còn Hàng" : "Hét Hàng"
                    );

            }
        }
        private void FrmGioHang_Load(object sender, EventArgs e)
        {
            var listSDT = (from x in _khachHangServices.GetAll() orderby x.SdtKH descending select x.SdtKH).ToList();
            cbbSDT.DataSource = listSDT;
            //var listDanhSach = (from y in _aophongchitietServices.getViewAophongCT() orderby y.aoPhongs.TenAoPhong select y).ToList();
            //dgvDanhSachSp.DataSource = listDanhSach;
        }



        private void cbbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = (from x in _khachHangServices.GetAll() where x.SdtKH==cbbSDT.Text  select x).FirstOrDefault();
            txtDiaChi.Text = list.DiaChiKH;
            txtHoTen.Text = list.TenKH;
          
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var list = (from y in _aoPhongServices.GetAll() where y.TenAoPhong.ToLower().StartsWith($"{txtTimKiem.Text}") select y).ToList();
            dgvDanhSachSp.DataSource=list;
        }
    }
}
