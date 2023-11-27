using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
using C.PL.Utilities;
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

namespace C.PL.Forms
{
    public partial class FrmNhanVien : Form
    {
        INhanVienService _Service;
        IChucVuServices _ChucVuServices;
        public FrmNhanVien()
        {
            InitializeComponent();
            _Service = new NhanVienService();
            _ChucVuServices = new ChucVuServices();
            loadData();
            loadChucVu();
        }
        private void loadData()
        {
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.ColumnCount = 10;
            dgvNhanVien.Columns[0].Name = "ID";
            dgvNhanVien.Columns[1].Name = "Họ tên";
            dgvNhanVien.Columns[2].Name = "Tài khoản";
            dgvNhanVien.Columns[3].Name = "Chức vụ";
            dgvNhanVien.Columns[4].Name = "Email";
            dgvNhanVien.Columns[5].Name = "SĐT";
            dgvNhanVien.Columns[6].Name = "Địa chỉ";
            dgvNhanVien.Columns[7].Name = "Giới tính";
            dgvNhanVien.Columns[8].Name = "Ngày sinh";
            dgvNhanVien.Columns[9].Name = "Trạng thái";
            foreach (var item in _Service.GetAll())
            {
                dgvNhanVien.Rows.Add(item.MaNV, item.TenNV, item.TaiKhoanNV, _ChucVuServices.GetAll().Where(x => x.MaChucVu == item.ChucVuId).Select(x => x.TenChucVu).FirstOrDefault(), item.EmailNV, item.SdtNV, item.DiaChiNV, item.GioiTinhNV == true ? "Nam" : "Nữ", item.DoBNV, item.TrangThai == true ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void loadChucVu()
        {
            var chucvu = _ChucVuServices.GetAll();
            foreach (var item in chucvu)
            {
                cbb_cv.Items.Add(item.TenChucVu);
            }
            cbb_cv.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var se = _Service.GetAll();
                foreach (var item in se)
                {
                    if (tb_ten.Text == "" || tb_TaiKhoan.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OKCancel);
                    }
                    else if (Validates.CheckEmail(tb_email.Text) == false)
                    {
                        MessageBox.Show("Bạn điền không đúng email", "Cảnh báo", MessageBoxButtons.OKCancel);
                    }
                    else if (Validates.CheckEmail(tb_sdt.Text) == false)
                    {
                        MessageBox.Show("Bạn điền không đúng số điện thoại", "Cảnh báo", MessageBoxButtons.OKCancel);
                    }
                    else if (item.TenNV == tb_ten.Text && item.DoBNV == DateTime.Parse(dt_DoB.Text) && item.SdtNV == tb_sdt.Text && item.EmailNV == tb_email.Text)
                    {
                        MessageBox.Show("Thông tin nhân viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                    }
                    else if (item.TaiKhoanNV == tb_TaiKhoan.Text)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        var cv = cbb_cv.SelectedItem as string;
                        NhanVien nv = new NhanVien()
                        {
                            MaNV = Guid.NewGuid(),
                            TenNV = tb_ten.Text,
                            SdtNV = tb_sdt.Text,
                            EmailNV = tb_email.Text,
                            DiaChiNV = tb_diachi.Text,
                            TaiKhoanNV = tb_TaiKhoan.Text,
                            MatKhauNV = "1",
                            DoBNV = DateTime.Parse(dt_DoB.Text),
                            GioiTinhNV = rbMale.Checked == true ? true : false,
                            ChucVuId = _ChucVuServices.GetAll().Where(x => x.TenChucVu == cbb_cv.SelectedItem).Select(x => x.MaChucVu).FirstOrDefault(),
                            TrangThai = rdOn.Checked == true ? true : false
                        };
                        _Service.AddNhanVien(nv);
                        MessageBox.Show("Thêm thành công");
                    }
                }
                loadData();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvNhanVien.Rows[e.RowIndex];
            lb_Id.Text = data.Cells[0].Value.ToString();
            tb_ten.Text = data.Cells[1].Value.ToString();
            tb_TaiKhoan.Text = data.Cells[2].Value.ToString();
            cbb_cv.Text = data.Cells[3].Value.ToString();
            tb_email.Text = data.Cells[4].Value.ToString();
            tb_sdt.Text = data.Cells[5].Value.ToString();
            tb_diachi.Text = data.Cells[6].Value.ToString();
            rbMale.Checked = data.Cells[7].Value.ToString() == "Nam" ? true : false;
            rbFemale.Checked = data.Cells[7].Value.ToString() == "Nữ" ? true : false;
            dt_DoB.Text = data.Cells[8].Value.ToString();
            rdOn.Checked = data.Cells[9].Value.ToString() == "Hoạt động" ? true : false;
            rdOff.Checked = data.Cells[9].Value.ToString() == "Không hoạt động" ? true : false;
        }
    }
}
