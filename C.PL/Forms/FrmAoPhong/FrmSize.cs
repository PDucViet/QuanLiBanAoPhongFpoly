using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = A.DAL.Models.Size;


namespace C.PL.Forms.FrmSanpham2
{
    public partial class FrmSize : Form
    {
        SizeServices _iSizeServices = new();
        List<Size> _size = new();
        Guid? _idcellclick = null;
        public FrmSize()
        {
            InitializeComponent();

        }
        public void loadSize()
        {
            dgvSize.Rows.Clear();
            dgvSize.ColumnCount = 3;
            dgvSize.Columns[0].Name = "Mã Size";
            dgvSize.Columns[1].Name = "Tên Size";
            dgvSize.Columns[2].Name = "Trạng thái Size";

            _size = _iSizeServices.GetAll();
            foreach (var item in _size)
            {
                dgvSize.Rows.Add(
                    item.MaSize,
                    item.TenSize,
                    item.TrangThaiSize == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _size.Count)
            {
                return;
            }
            var doituongcellclick = _size[index];
            _idcellclick = doituongcellclick.MaSize;
            txtTenSize.Text = doituongcellclick.TenSize;
            rb_HoatDong.Checked = doituongcellclick.TrangThaiSize == true;
            rb_KHD.Checked = doituongcellclick.TrangThaiSize == false;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtTenSize.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (rb_KHD.Checked == false && rb_HoatDong.Checked == false)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (_iSizeServices.checktrung(txtTenSize.Text))
                {
                    MessageBox.Show("Trùng tên. Hãy nhập tên khác.");
                }
                else
                {
                    Size size = new Size()
                    {
                        MaSize = Guid.NewGuid(),
                        TenSize = txtTenSize.Text,
                        TrangThaiSize = rb_HoatDong.Checked,
                    };
                    _iSizeServices.Add(size);
                    loadSize();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }


        private void FrmSize_Load(object sender, EventArgs e)
        {
            loadSize();
        }

        private void rb_HoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_HoatDong.Checked)
            {
                rb_KHD.Checked = false;
            }
        }

        private void rb_KHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_KHD.Checked)
            {
                rb_HoatDong.Checked = false;
            }
        }  

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txtTenSize.Text = "";
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                var resultsua = _iSizeServices.Update((Guid)_idcellclick, new Size()
                {
                    TenSize = txtTenSize.Text,
                    TrangThaiSize = rb_HoatDong.Checked
                });

                if (resultsua)
                {
                    MessageBox.Show("Sửa thành công");
                    loadSize();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }
    }
}
