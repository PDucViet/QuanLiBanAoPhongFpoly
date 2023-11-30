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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.PL.Views
{
    public partial class FrmAoPhongChiTiet : Form
    {
        private IAophongchitietServices _aophongchitietServices;
        private IAoPhongServices _aophongServices;
        private IChatLieuServices _chatlieuServices;
        private IHangServices _ihangServices;
        private IMauSacServices _imauServices;
        private ISizeServices _iSizeServices;
        private List<AoPhongCT> _aophongchitiet;
        Guid? _idcellclick = null;
        public FrmAoPhongChiTiet()
        {
            _aophongchitietServices = new AophongchitietServices();
            _aophongServices = new AoPhongServices();
            _chatlieuServices = new ChatLieuServices();
            _ihangServices = new HangServices();
            _imauServices = new MauSacServices();
            _iSizeServices = new SizeServices();
            _aophongchitiet = new List<AoPhongCT>();
            InitializeComponent();
            loadDuLieu();
            LoadAophong();
            LoadChatLieu();
            LoadMauSac();
            LoadSize();
            LoadNhaSanXuat();
            rbConHang.Checked = true;
        }

        public void LoadNhaSanXuat()
        {
            var nsx = _ihangServices.GetAll().Where(x => x.TrangThaiHSX == true);
            foreach (var item in nsx)
            {
                cbNSX.Items.Add(item.TenHSX.ToString());
            }
            cbNSX.SelectedIndex = 0;

        }
        public void LoadMauSac()
        {
            var mau = _imauServices.GetAll().Where(x => x.TrangThaiMu == true);
            foreach (var item in mau)
            {
                cbMau.Items.Add(item.TenMau.ToString());
            }
            cbMau.SelectedIndex = 0;

        }
        public void LoadSize()
        {
            var size = _iSizeServices.GetAll().Where(x => x.TrangThaiSize == true);
            foreach (var item in size)
            {
                cbSize.Items.Add(item.TenSize.ToString());
            }
            cbSize.SelectedIndex = 0;
        }
        public void LoadChatLieu()
        {
            var loaiCL = _chatlieuServices.GetAll().Where(x => x.TrangThaiChatLieu == true);
            foreach (var item in loaiCL)
            {
                cbChatLieu.Items.Add(item.TenChatLieu);
            }
            cbChatLieu.SelectedIndex = 0;
        }
        public void LoadAophong()
        {
            var Aophong = _aophongServices.GetAll().Where(x => x.TrangThaiAoPhong == true);
            foreach (var item in Aophong)
            {
                cbaophong.Items.Add(item.TenAoPhong);
            }
            cbaophong.SelectedIndex = 0;
        }
        public void loadDuLieu()
        {
            dgvAoPhongchitiet.Rows.Clear();
            dgvAoPhongchitiet.ColumnCount = 10;
            dgvAoPhongchitiet.Columns[0].Name = "Mã Áo Phông";
            dgvAoPhongchitiet.Columns[1].Name = "Tên Áo Phông";
            dgvAoPhongchitiet.Columns[2].Name = "Giá Nhập";
            dgvAoPhongchitiet.Columns[3].Name = "Giá Bán";
            dgvAoPhongchitiet.Columns[4].Name = "Số Lượng";
            dgvAoPhongchitiet.Columns[5].Name = "Màu Sắc";
            dgvAoPhongchitiet.Columns[6].Name = "Size";
            dgvAoPhongchitiet.Columns[7].Name = "HangSX";
            dgvAoPhongchitiet.Columns[8].Name = "Chất liệu";
            dgvAoPhongchitiet.Columns[9].Name = "Trạng Thái Áo Phông CT";
            foreach (var item in _aophongchitietServices.getViewAophongCT())
            {
                dgvAoPhongchitiet.Rows.Add(
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
        private void btn_capNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var Maucb = _imauServices.GetAll().Where(c => c.TenMau == cbMau.SelectedItem).Select(c => c.MaMau).FirstOrDefault();
            var Aocb = _aophongServices.GetAll().Where(c => c.TenAoPhong == cbaophong.SelectedItem).Select(c => c.MaAoPhong).FirstOrDefault();
            var Hangcb = _ihangServices.GetAll().Where(c => c.TenHSX == cbNSX.SelectedItem).Select(c => c.MaHSX).FirstOrDefault();
            var Chatlieucb = _chatlieuServices.GetAll().Where(c => c.TenChatLieu == cbChatLieu.SelectedItem).Select(c => c.MaChatLieu).FirstOrDefault();
            var Sizecb = _iSizeServices.GetAll().Where(c => c.TenSize == cbSize.SelectedItem).Select(c => c.MaSize).FirstOrDefault();
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                int soLuong;
                float giaNhap;
                float giaBan;
                if (txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống!!");
                    return;
                }
                else if (!float.TryParse(txtGiaNhap.Text, out giaNhap) || giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập không hợp lệ");
                    return;
                }
                else if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ");
                    return;
                }


                else if (!float.TryParse(txtGiaNhap.Text, out giaNhap) || giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập không hợp lệ");
                    return;
                }

                else if (!float.TryParse(txtGiaBan.Text, out giaBan) || giaBan <= 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ");
                    return;
                }

                else if (giaNhap > giaBan)
                {
                    MessageBox.Show("Vui lòng nhập giá bán lớn hơn giá nhập");
                    return;
                }

                {
                    AoPhongCT aoct = new()
                    {
                        MaAoPhongCT = Guid.NewGuid(),
                        AoPhongId = Aocb,
                        GiaNhap = float.Parse(txtGiaNhap.Text),
                        GiaBan = float.Parse(txtGiaBan.Text),
                        SoLuong = Convert.ToInt32(txtSoLuong.Text),
                        MauId = Maucb,
                        SizeId = Sizecb,
                        HangSXId = Hangcb,
                        ChatLieuId = Chatlieucb,
                        TrangThaiAoPhongCT = rbConHang.Checked                                              
                    };
                    _aophongchitietServices.Add(aoct);
                    MessageBox.Show("Thêm thành công");
                    loadDuLieu();
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvAoPhongchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
