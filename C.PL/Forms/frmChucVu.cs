
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

namespace C.PL.Views
{
    public partial class frmChucVu : Form
    {
        IChucVuServices _ichucVuServices;
        ChucVu chucVu;
        public frmChucVu()
        {
            InitializeComponent();
            _ichucVuServices = new ChucVuServices();
            chucVu = new ChucVu();
            loadChucVu();
        }
        public void loadChucVu()
        {

            dgvChucVu.Rows.Clear();

        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            txtMaChucVu.Hide();
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            var dgv = (from x in _ichucVuServices.GetAll() orderby x.TenChucVu select x).ToList();
            dgvChucVu.DataSource = dgv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtTenChucVu.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else
                {
                    ChucVu chucVu = new ChucVu()
                    {
                        MaChucVu = Guid.NewGuid(),
                        TenChucVu = txtTenChucVu.Text,
                    };
                    _ichucVuServices.Add(chucVu);
                    frmChucVu_Load(sender, e); MessageBox.Show("Thêm thành công");
                }
            }
        }

            private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtTenChucVu.Text == null)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else
                {
                    var chucvu = (from x in _ichucVuServices.GetAll() where x.MaChucVu == Guid.Parse(txtMaChucVu.Text) select x).FirstOrDefault();
                    chucvu.TenChucVu = txtTenChucVu.Text;
                    _ichucVuServices.Update(chucvu);
                    frmChucVu_Load(sender, e);
                    MessageBox.Show("Sửa thành công.");
                }
            }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvChucVu.Rows[e.RowIndex];
            txtMaChucVu.Text = data.Cells[0].Value.ToString();
            txtTenChucVu.Text = data.Cells[1].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var data = (from x in _ichucVuServices.GetAll() where x.TenChucVu.StartsWith($"{txtTimKiem.Text}") select x).ToList();
            if (data.Count == 0)
            {
                MessageBox.Show("Tên không tồn tại.");
            }
            else
            {
                dgvChucVu.DataSource = data;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var xoa = (from x in _ichucVuServices.GetAll() where Convert.ToString(x.MaChucVu) == txtMaChucVu.Text select x).FirstOrDefault();

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtMaChucVu.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn item muốn xóa!");
                }
                else
                {
                    _ichucVuServices.Delete(xoa);
                    frmChucVu_Load(sender, e);
                    MessageBox.Show("Xóa thành công.");

                }

            }
        }
    }
}
