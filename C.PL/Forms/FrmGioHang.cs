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
            dgvDanhSachSp.Columns[0].Visible = false;
            dgvGioHang.Columns[0].Visible = false;
            dgvDanhSachSp.Rows.Clear();
            dgvDanhSachSp.ColumnCount = 10;
            dgvDanhSachSp.Columns[0].Name = "Mã Áo Phông";
            dgvDanhSachSp.Columns[1].Name = "Tên Áo Phông";
            //dgvDanhSachSp.Columns[2].Name = "Giá Nhập";
            dgvDanhSachSp.Columns[2].Name = "Giá Bán";
            dgvDanhSachSp.Columns[3].Name = "Số Lượng";
            dgvDanhSachSp.Columns[4].Name = "Màu Sắc";
            dgvDanhSachSp.Columns[5].Name = "Size";
            dgvDanhSachSp.Columns[6].Name = "HangSX";
            dgvDanhSachSp.Columns[7].Name = "Chất liệu";
            dgvDanhSachSp.Columns[8].Name = "Trạng Thái Áo Phông CT";
            dgvDanhSachSp.Columns[0].Width = 10;

            foreach (var item in _aophongchitietServices.getViewAophongCT())
            {
                dgvDanhSachSp.Rows.Add(
                    item.aoPhongCTs.MaAoPhongCT,
                    item.aoPhongs.TenAoPhong,
                    //item.aoPhongCTs.GiaNhap,
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
            var list = (from x in _khachHangServices.GetAll() where x.SdtKH == cbbSDT.Text select x).FirstOrDefault();
            txtDiaChi.Text = list.DiaChiKH;
            txtHoTen.Text = list.TenKH;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var list = (from y in _aoPhongServices.GetAll() where y.TenAoPhong.ToLower().StartsWith($"{txtTimKiem.Text}") select y).ToList();
            dgvDanhSachSp.DataSource = list;
        }

        private void dgvDanhSachSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDanhSachSp.Rows[e.RowIndex].Cells[0].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[1].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[2].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[3].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[4].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[5].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[6].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[7].Value != null && dgvDanhSachSp.Rows[e.RowIndex].Cells[8].Value != null)
            {
                for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
                {

                    if (dgvGioHang.Rows[i].Cells[0].Value == dgvDanhSachSp.Rows[e.RowIndex].Cells[0].Value)
                    {
                        MessageBox.Show("Bạn đã thêm sản phẩm này vào giỏ hàng");
                        return;
                    }
                    return;

                }
                dgvGioHang.Rows.Add(
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[0].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[1].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[2].Value,
                          int.Parse(""),
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[2].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[4].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[5].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[6].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[7].Value,
                   dgvDanhSachSp.Rows[e.RowIndex].Cells[8].Value
                   );
            }
            else
            {
                MessageBox.Show("Bạn không thể thêm sản phẩm này");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dgvGioHang.SelectedRows[0].Cells[3].Value.ToString());
            var id = Guid.Parse(dgvGioHang.SelectedRows[0].Cells[0].Value.ToString());
            if (sl < _aophongchitietServices.getViewAophongCT().Where(x => x.aoPhongCTs.AoPhongId == id).Select(s => s.aoPhongCTs.SoLuong).First())
            {
                sl++;
                dgvGioHang.SelectedRows[0].Cells[3].Value = sl;
                float dongia = float.Parse(dgvGioHang.SelectedRows[0].Cells[2].Value.ToString());
                dgvGioHang.SelectedRows[0].Cells[4].Value = float.Parse(sl.ToString()) * dongia;
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa toàn bộ giỏ hàng không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dgvGioHang.Rows.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này khỏi giỏ hàng không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow x in dgvGioHang.SelectedRows)
                {
                    dgvGioHang.Rows.Remove(x);
                }
            }
            }

        private void btnTruSoLuong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dgvGioHang.SelectedRows[0].Cells[3].Value.ToString());
            if (sl > 1)
            {
                sl--;
            }
            else MessageBox.Show("Số lượng không thể nhỏ hơn 1");
            dgvGioHang.SelectedRows[0].Cells[3].Value = sl;
            float dongia = float.Parse(dgvGioHang.SelectedRows[0].Cells[2].Value.ToString());
            dgvGioHang.SelectedRows[0].Cells[4].Value = float.Parse(sl.ToString()) * dongia;
        }
    }
}