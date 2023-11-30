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

namespace C.PL.Forms.FrmDangNhap
{
    public partial class frmDoiMatKhau : Form
    {
        INhanVienService _service;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }
        private void check()
        {
            var lst = _service.GetAll();
            foreach (var item in lst)
            {
                if (item.TaiKhoanNV == txtUser.Text && item.MatKhauNV == txtOldPass.Text)
                {
                    item.MatKhauNV = txtNewPsss.Text;
                    _service.UpdateNhanVien(item);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    Reset();
                    return;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            check();
        }
        private void Reset()
        {
            txtUser.Text = "";
            txtOldPass.Text = "";
            txtNewPsss.Text = "";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
