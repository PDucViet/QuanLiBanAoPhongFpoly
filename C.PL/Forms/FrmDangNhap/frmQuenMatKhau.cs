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
    public partial class frmQuenMatKhau : Form
    {
        INhanVienService _service;
        public frmQuenMatKhau()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                FUNC.MailSupport mail = new FUNC.MailSupport("vietpdph30773@fpt.edu.vn", "Viet3006");
                string new_pass = Guid.NewGuid().ToString().Substring(0, 8);
                var taikhoan = _service.GetAll().FirstOrDefault(c => c.EmailNV == textBox1.Text);
                if (taikhoan != null)
                {
                    mail.send(textBox1.Text,
                   "Yêu cầu lấy lại mật khẩu",
                   string.Format("đây là mật khẩu mới của bạn: {0}", new_pass));
                    taikhoan.MatKhauNV = new_pass;
                    _service.UpdateNhanVien(taikhoan);
                    MessageBox.Show("Chúng tôi đã gửi mật khẩu tới email của bạn");
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " không tồn tại ");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email xác thực");
            }
        }
    }
}
