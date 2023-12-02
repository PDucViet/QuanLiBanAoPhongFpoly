using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
using C.PL.Utilities;
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
    public partial class FrmKhachHang : Form
    {
        IKhachHangServices _ikhachHangServices;
        KhachHang khachHang;
        public FrmKhachHang()
        {
            InitializeComponent();
            _ikhachHangServices = new KhachHangServices();
            khachHang = new KhachHang();
            load();
        }
        public void load()
        {
            dgvKhachHang.Rows.Clear();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Hide();
            txtDiaChi.Text = "";
            txtMaKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            var dgv = (from x in _ikhachHangServices.GetAll() orderby x.TenKH select x).ToList();
            dgvKhachHang.DataSource = dgv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var list = (from x in _ikhachHangServices.GetAll() orderby x.TenKH select x).ToList();
            bool check = false;

            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].TenKH == txtTenKhachHang.Text && list[i].SdtKH == txtSDT.Text && list[i].DiaChiKH == txtDiaChi.Text)
                    {
                        MessageBox.Show("Thông tin khách hàng đã tồn tại!!");
                        check = true;
                        break;
                    }
                }
                if (txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                    check = true;
                    return;
                }
                else if (Validates.CheckSDT(txtSDT.Text) == false)
                {
                    MessageBox.Show("Sai SDT!!");
                    check = true;
                    return;
                }

                else if (check)
                {
                    return;
                }

                KhachHang khachHang = new KhachHang()
                {
                    MaKH = Guid.NewGuid(),
                    TenKH = txtTenKhachHang.Text,
                    DiaChiKH = txtDiaChi.Text,
                    SdtKH = txtSDT.Text,
                    GioiTinhKH = rbNam.Checked == true ? true : false,
                };
                _ikhachHangServices.Add(khachHang);
                FrmKhachHang_Load(sender, e);
                MessageBox.Show("Thêm thành công");

            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvKhachHang.Rows[e.RowIndex];
            txtMaKhachHang.Text = data.Cells[0].Value.ToString();
            txtTenKhachHang.Text = data.Cells[1].Value.ToString();
            txtDiaChi.Text = data.Cells[3].Value.ToString();
            txtSDT.Text = data.Cells[2].Value.ToString();
            if (data.Cells[4].Value.ToString().ToLower() == "true")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var list = (from x in _ikhachHangServices.GetAll() orderby x.TenKH select x).ToList();
            var tt = (from y in list where y.MaKH == Guid.Parse(txtMaKhachHang.Text) select y).FirstOrDefault();
            bool check = false;
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].TenKH == txtTenKhachHang.Text && list[i].SdtKH == txtSDT.Text && list[i].DiaChiKH == txtDiaChi.Text)
                    {
                        MessageBox.Show("Thông tin khách hàng đã tồn tại!!");
                        check = true;
                        break;
                    }
                }
                if (txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                    check = true;
                    return;
                }
                else if (Validates.CheckSDT(txtSDT.Text) == false)
                {
                    MessageBox.Show("Sai SDT!!");
                    check = true;
                    return;
                }

                else if (check)
                {
                    return;
                }
                tt.TenKH = txtTenKhachHang.Text;
                tt.DiaChiKH = txtDiaChi.Text;
                tt.SdtKH = txtSDT.Text;
                tt.GioiTinhKH = rbNam.Checked == true ? true : false;
                _ikhachHangServices.Update(tt);
                FrmKhachHang_Load(sender, e);
                MessageBox.Show("Sửa thành công.");
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var lists = (from x in _ikhachHangServices.GetAll() where x.TenKH.StartsWith($"{txtTimKiem}") select x).ToList();
            dgvKhachHang.DataSource = lists;
        }
    }
}
