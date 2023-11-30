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
        }

        public void LoadNhaSanXuat()
        {
            var nsx = _ihangServices.GetAll().Where(x => x.TrangThaiHSX == true);
            foreach (var item in nsx)
            {
                cbNSX.Items.Add(item.TenHSX.ToString());
            }
            
        }
        public void LoadMauSac()
        {
            var mau = _imauServices.GetAll().Where(x => x.TrangThaiMu == true);
            foreach (var item in mau)
            {
                cbMau.Items.Add(item.TenMau.ToString());
            }
            
        }
        public void LoadSize()
        {
            var size = _iSizeServices.GetAll().Where(x => x.TrangThaiSize == true);
            foreach (var item in size)
            {
                cbSize.Items.Add(item.TenSize.ToString());
            }
            
        }
        public void LoadChatLieu()
        {
            var loaiCL = _chatlieuServices.GetAll().Where(x => x.TrangThaiChatLieu == true);
            foreach (var item in loaiCL)
            {
                cbChatLieu.Items.Add(item.TenChatLieu);
            }
            
        }
        public void LoadAophong()
        {
            var Aophong = _aophongServices.GetAll().Where(x => x.TrangThaiAoPhong == true);
            foreach (var item in Aophong)
            {
                cbaophong.Items.Add(item.TenAoPhong);
            }
            
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
            var Maucb = _imauServices.GetAll().Where(c =>c.TenMau == cbMau.SelectedItem).Select(c =>c.MaMau).FirstOrDefault();
            var Aocb = _aophongServices.GetAll().Where(c =>c.TenAoPhong == cbaophong.SelectedItem).Select(c =>c.MaAoPhong).FirstOrDefault();
            var Hangcb = _ihangServices.GetAll().Where(c =>c.TenHSX == cbNSX.SelectedItem).Select(c =>c.MaHSX).FirstOrDefault();
            var Chatlieucb = _chatlieuServices.GetAll().Where(c =>c.TenChatLieu == cbChatLieu.SelectedItem).Select(c =>c.MaChatLieu).FirstOrDefault();
            var Sizecb = _iSizeServices.GetAll().Where(c =>c.TenSize == cbSize.SelectedItem).Select(c =>c.MaSize).FirstOrDefault();
           DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {                            
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
    }
}
