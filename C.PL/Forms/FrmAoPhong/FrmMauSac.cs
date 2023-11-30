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
    public partial class FrmMauSac : Form
    {
        MauSacServices _imauServices = new();
        List<Mau> _mau = new();
        Guid? _idcellclick = null;
        public FrmMauSac()
        {
            InitializeComponent();
        }
        public void loadMau()
        {
            dgv_Mau.Rows.Clear();
            dgv_Mau.ColumnCount = 3;
            dgv_Mau.Columns[0].Name = "Mã Màu";
            dgv_Mau.Columns[1].Name = "Tên Màu";
            dgv_Mau.Columns[2].Name = "Trạng thái Màu";

            _mau = _imauServices.GetAll();
            foreach (var item in _mau)
            {
                dgv_Mau.Rows.Add(
                    item.MaMau,
                    item.TenMau,
                    item.TrangThaiMu == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txt_TenMau.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (rb_KHD.Checked == false && rb_HoatDong.Checked == false)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (_imauServices.checktrung(txt_TenMau.Text))
                {
                    MessageBox.Show("Trùng tên. Hãy nhập tên khác.");
                }
                else
                {
                    Mau mau = new Mau()
                    {
                        MaMau = Guid.NewGuid(),
                        TenMau = txt_TenMau.Text,
                        TrangThaiMu = rb_HoatDong.Checked,
                    };
                    _imauServices.Add(mau);
                    loadMau();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (_idcellclick != null)
                {
                    var resultDelete = _imauServices.Detele((Guid)_idcellclick);

                    if (resultDelete)
                    {
                        MessageBox.Show("Xóa thành công");
                        loadMau();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TenMau.Text = "";
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

        private void dgv_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var doituongcellclick = _mau[index];
            _idcellclick = doituongcellclick.MaMau;
            txt_TenMau.Text = doituongcellclick.TenMau;
            rb_HoatDong.Checked = doituongcellclick.TrangThaiMu == true;
            rb_KHD.Checked = doituongcellclick.TrangThaiMu == false;
        }

        private void FrmMauSac_Load(object sender, EventArgs e)
        {
            loadMau();
        }
    }
}
