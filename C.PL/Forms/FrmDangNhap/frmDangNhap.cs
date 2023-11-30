using B.BUS.IServices;
using B.BUS.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmDangNhap : Form
    {
        INhanVienService _service;
        IChucVuServices _chucVuServices;

        public bool False { get; private set; }

        public frmDangNhap()
        {
            InitializeComponent();
            _service = new NhanVienService();
            _chucVuServices = new ChucVuServices();
        }
        private void check()
        {
            var ql = _chucVuServices.GetAll().Where(x => x.TenChucVu == "Quản lý").Select(x => x.MaChucVu).FirstOrDefault();
            var nv = _chucVuServices.GetAll().Where(x => x.TenChucVu == "Nhân viên").Select(x => x.MaChucVu).FirstOrDefault();
            var lst = _service.GetAll();
            bool check = false;
            foreach (var item in lst)
            {
                if (item.TaiKhoanNV == txtUser.Text && item.MatKhauNV == txtPassWord.Text)
                {
                    if (item.ChucVuId == ql)
                    {
                        MessageBox.Show("Bạn đăng nhập với tư cách quản lí");
                        FormQuanLy f = new FormQuanLy();
                        f.ShowDialog();
                        check = true;
                        break;
                    }
                    else if (item.ChucVuId == nv)
                    {
                        MessageBox.Show("Bạn đăng nhập với tư cách nhân viên");
                        FormNhanVien f = new FormNhanVien();
                        f.ShowDialog();
                        check = true;
                        break;
                    }
                }
            }
            if(!check)
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
