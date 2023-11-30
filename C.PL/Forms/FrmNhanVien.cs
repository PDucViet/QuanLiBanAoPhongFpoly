using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
using C.PL.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                bool check = false;
                var cv = cbb_cv.SelectedItem as string;
                var se = _Service.GetAll();

                if (tb_ten.Text == "" || tb_TaiKhoan.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OKCancel);
                    check = true;
                    return;
                }
                else if (Validates.CheckEmail(tb_email.Text) == false)
                {
                    MessageBox.Show("Bạn điền không đúng email", "Cảnh báo", MessageBoxButtons.OKCancel);
                    check = true;
                    return;
                }
                else if (Validates.CheckSDT(tb_sdt.Text) == false)
                {
                    MessageBox.Show("Bạn điền không đúng số điện thoại", "Cảnh báo", MessageBoxButtons.OKCancel);
                    check = true;
                    return;
                }
                foreach (var item in se)
                {

                    if (item.SdtNV == tb_sdt.Text)
                    {
                        MessageBox.Show("SĐT này đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                        check = true;
                        break;
                    }
                    else if (item.EmailNV == tb_email.Text)
                    {
                        MessageBox.Show("Email này đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                        check = true;
                        break;
                    }
                    else if (item.TaiKhoanNV == tb_TaiKhoan.Text)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    return;
                }
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
                    ChucVuId = _ChucVuServices.GetAll().Where(x => x.TenChucVu == cv).Select(x => x.MaChucVu).FirstOrDefault(),
                    TrangThai = rdOn.Checked == true ? true : false
                };
                _Service.AddNhanVien(nv);
                MessageBox.Show("Thêm thành công");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            lb_Id.Text = "";
            tb_ten.Text = "";
            tb_TaiKhoan.Text = "";
            tb_diachi.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            dt_DoB.Text = DateTime.Now.ToString();
            cbb_cv.SelectedIndex = 0;
            rbMale.Checked = true;
            rdOn.Checked = true;
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cv = cbb_cv.SelectedItem as string;
            var lst = _Service.GetAll();
            //var IdNvUp = Guid.Parse(lb_Id.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa thông tin trên ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Guid.TryParse(lb_Id.Text, out var IdNvUp))
                {
                    var nvUp = lst.Where(x => x.MaNV == IdNvUp).FirstOrDefault();
                    if (nvUp != null)
                    {
                        var lstNV = lst.Where(x => x.MaNV != IdNvUp).ToList();
                        bool check = false;
                        if (tb_ten.Text == "" || tb_TaiKhoan.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_diachi.Text == "")
                        {
                            MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OKCancel);
                            check = true;
                            return;
                        }
                        else if (Validates.CheckEmail(tb_email.Text) == true)
                        {
                            MessageBox.Show("Bạn điền không đúng email", "Cảnh báo", MessageBoxButtons.OKCancel);
                            check = true;
                            return;
                        }
                        else if (Validates.CheckEmail(tb_sdt.Text) == true)
                        {
                            MessageBox.Show("Bạn điền không đúng số điện thoại", "Cảnh báo", MessageBoxButtons.OKCancel);
                            check = true;
                            return;
                        }
                        for (int i = 0; i < lstNV.Count; i++)
                        {

                            // if (lstNV[i].TenNV == tb_ten.Text && lstNV[i].SdtNV == tb_sdt.Text && lstNV[i].EmailNV == tb_email.Text)
                            //{
                            //    MessageBox.Show("Thông tin nhân viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                            //    return;
                            //}
                            if (lstNV[i].SdtNV == tb_sdt.Text)
                            {
                                MessageBox.Show("SĐT này đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                                check = true;
                                break;
                            }
                            else if (lstNV[i].EmailNV == tb_email.Text)
                            {
                                MessageBox.Show("Email này đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                                check = true;
                                break;
                            }
                            else if (lstNV[i].TaiKhoanNV == tb_TaiKhoan.Text)
                            {
                                MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel);
                                check = true;
                                break;
                            }
                        }
                        if (check)
                        {
                            return;
                        }
                        nvUp.TenNV = tb_ten.Text;
                        nvUp.DoBNV = DateTime.Parse(dt_DoB.Text);
                        nvUp.ChucVuId = _ChucVuServices.GetAll().Where(x => x.TenChucVu == cv).Select(x => x.MaChucVu).FirstOrDefault();
                        nvUp.DiaChiNV = tb_diachi.Text;
                        nvUp.SdtNV = tb_sdt.Text;
                        nvUp.EmailNV = tb_email.Text;
                        nvUp.TrangThai = rdOn.Checked == true ? true : false;
                        nvUp.GioiTinhNV = rbMale.Checked == true ? true : false;
                        nvUp.TaiKhoanNV = tb_TaiKhoan.Text;
                        _Service.UpdateNhanVien(nvUp);
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin nhân viên không tồn tại");
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần sửa thông tin");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var lst = _Service.GetAll().Where(x => x.TenNV == tbSearch.Text || x.TaiKhoanNV == tbSearch.Text).ToList();
            if (lst.Count > 0)
            {
                dgvNhanVien.Rows.Clear();
                foreach (var item in lst)
                {
                    dgvNhanVien.Rows.Add(item.MaNV, item.TenNV, item.TaiKhoanNV, _ChucVuServices.GetAll().Where(x => x.MaChucVu == item.ChucVuId).Select(x => x.TenChucVu).FirstOrDefault(), item.EmailNV, item.SdtNV, item.DiaChiNV, item.GioiTinhNV == true ? "Nam" : "Nữ", item.DoBNV, item.TrangThai == true ? "Hoạt động" : "Không hoạt động");
                }
            }
            else
            {
                MessageBox.Show("Thông tin nhân viên không tồn tại");
                loadData();
            }
        }
    }
}

