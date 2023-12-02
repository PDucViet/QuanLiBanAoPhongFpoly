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

namespace C.PL.Forms.FrmSanpham2
{
    public partial class FrmAoPhong : Form
    {
        AoPhongServices _aophongServices = new();
        List<AoPhong> _aophong = new();
        Guid? _idcellclick = null;
        public FrmAoPhong()
        {
            InitializeComponent();
        }
        public void loadaophong()
        {
            dgv_Aophong.Rows.Clear();
            dgv_Aophong.ColumnCount = 3;
            dgv_Aophong.Columns[0].Name = "Mã Áo Phông";
            dgv_Aophong.Columns[1].Name = "Tên Áo Phông";
            dgv_Aophong.Columns[2].Name = "Trạng thái Áo Phông";

            _aophong = _aophongServices.GetAll();
            foreach (var item in _aophong)
            {
                dgv_Aophong.Rows.Add(
                    item.MaAoPhong,
                    item.TenAoPhong,
                    item.TrangThaiAoPhong == true ? "Còn Hàng" : "Hét Hàng");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txt_tenAophong.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (rb_KHD.Checked == false && rb_HoatDong.Checked == false)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (_aophongServices.checktrung(txt_tenAophong.Text))
                {
                    MessageBox.Show("Trùng tên. Hãy nhập tên khác.");
                }
                else
                {
                    AoPhong aoPhong = new AoPhong()
                    {
                        MaAoPhong = Guid.NewGuid(),
                        TenAoPhong = txt_tenAophong.Text,
                        TrangThaiAoPhong = rb_HoatDong.Checked,
                    };
                    _aophongServices.Add(aoPhong);
                    loadaophong();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }


        private void btn_lamMoi_Click(object sender, EventArgs e)
        {

            txt_tenAophong.Text = "";
            rb_HoatDong.Checked = false;
            rb_KHD.Checked = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_Aophong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _aophong.Count)
            {
                return;
            }
            var doituongcellclick = _aophong[index];
            _idcellclick = doituongcellclick.MaAoPhong;
            txt_tenAophong.Text = doituongcellclick.TenAoPhong;
            rb_HoatDong.Checked = doituongcellclick.TrangThaiAoPhong == true;
            rb_KHD.Checked = doituongcellclick.TrangThaiAoPhong == false;
        }

        private void FrmAoPhong_Load(object sender, EventArgs e)
        {
            loadaophong();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                var resultsua = _aophongServices.Update((Guid)_idcellclick, new AoPhong()
                {
                    TenAoPhong = txt_tenAophong.Text,
                    TrangThaiAoPhong = rb_HoatDong.Checked
                });

                if (resultsua)
                {
                    MessageBox.Show("Sửa thành công");
                    loadaophong();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }
    }
}
