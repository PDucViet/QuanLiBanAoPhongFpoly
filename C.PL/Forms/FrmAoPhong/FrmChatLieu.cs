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
    public partial class FrmChatLieu : Form
    {
        ChatLieuServices _chatlieuServices = new();
        List<ChatLieu> _chatlieu = new();
        Guid? _idcellclick = null;
        public FrmChatLieu()
        {
            InitializeComponent();
        }
        public void loadchatlieu()
        {
            dgv_Chatlieu.Rows.Clear();
            dgv_Chatlieu.ColumnCount = 3;
            dgv_Chatlieu.Columns[0].Name = "Mã Chất liệu";
            dgv_Chatlieu.Columns[1].Name = "Tên Chất liệu";
            dgv_Chatlieu.Columns[2].Name = "Trạng thái Chất liệu";

            _chatlieu = _chatlieuServices.GetAll();
            foreach (var item in _chatlieu)
            {
                dgv_Chatlieu.Rows.Add(
                    item.MaChatLieu,
                    item.TenChatLieu,
                    item.TrangThaiChatLieu == true ? "Còn hàng" : "Hết hàng");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txt_chatlieu.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (rb_KHD.Checked == false && rb_HoatDong.Checked == false)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (_chatlieuServices.checktrung(txt_chatlieu.Text))
                {
                    MessageBox.Show("Trùng tên. Hãy nhập tên khác.");
                }
                else
                {
                    ChatLieu chatLieu = new ChatLieu()
                    {
                        MaChatLieu = Guid.NewGuid(),
                        TenChatLieu = txt_chatlieu.Text,
                        TrangThaiChatLieu = rb_HoatDong.Checked,
                    };
                    _chatlieuServices.Add(chatLieu);
                    loadchatlieu();
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
                    var resultDelete = _chatlieuServices.Detele((Guid)_idcellclick);

                    if (resultDelete)
                    {
                        MessageBox.Show("Xóa thành công");
                        loadchatlieu();
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
            txt_chatlieu.Text = "";
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

        private void dgv_Chatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var doituongcellclick = _chatlieu[index];
            _idcellclick = doituongcellclick.MaChatLieu;
            txt_chatlieu.Text = doituongcellclick.TenChatLieu;
            rb_HoatDong.Checked = doituongcellclick.TrangThaiChatLieu == true;
            rb_KHD.Checked = doituongcellclick.TrangThaiChatLieu == false;
        }

        private void FrmChatLieu_Load(object sender, EventArgs e)
        {
            loadchatlieu();
        }
    }
}
