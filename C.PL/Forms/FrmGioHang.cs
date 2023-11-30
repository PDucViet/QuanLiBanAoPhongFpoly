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
        HoaDonChiTiet hoaDonChiTiet;
        KhachHang khachHang;
        AoPhong aoPhong;

        public FrmGioHang()
        {
            InitializeComponent();
            IAoPhongServices aoPhongServices = new AoPhongServices();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _khachHangServices = new KhachHangServices();
            _aoPhongServices = new AoPhongServices();
            hoaDonChiTiet = new HoaDonChiTiet();
            khachHang = new KhachHang();
            aoPhong = new AoPhong();
        }

        private void FrmGioHang_Load(object sender, EventArgs e)
        {
            var listSDT = (from x in _khachHangServices.GetAll() orderby x.SdtKH descending select x.SdtKH).ToList();
            cbbSDT.DataSource = listSDT;
            
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
