﻿using A.DAL.Models;
using B.BUS.IServices;
using B.BUS.Services;
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

namespace C.PL.Forms
{
    public partial class FrmHang : Form
    {
        HangServices _ihangServices = new();
        List<HangSX> _hang = new();
        Guid? _idcellclick = null;
        public FrmHang()
        {
            InitializeComponent();
        }
        public void loadHang()
        {
            dgv_NSX.Rows.Clear();
            dgv_NSX.ColumnCount = 3;
            dgv_NSX.Columns[0].Name = "Mã Hãng";
            dgv_NSX.Columns[1].Name = "Tên Hãng";
            dgv_NSX.Columns[2].Name = "Trạng thái Hãng";

            _hang = _ihangServices.GetAll();
            foreach (var item in _hang)
            {
                dgv_NSX.Rows.Add(
                    item.MaHSX,
                    item.TenHSX,
                    item.TrangThaiHSX == true ? "Còn hoạt động" : "Không hoạt động");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txt_TenNSX.Text == "")
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (rb_KHD.Checked == false && rb_HoatDong.Checked == false)
                {
                    MessageBox.Show("Thông tin không được trống!!");
                }
                else if (_ihangServices.checktrung(txt_TenNSX.Text))
                {
                    MessageBox.Show("Trùng tên. Hãy nhập tên khác.");
                }
                else
                {
                    HangSX hang = new HangSX()
                    {
                        MaHSX = Guid.NewGuid(),
                        TenHSX = txt_TenNSX.Text,
                        TrangThaiHSX = rb_HoatDong.Checked,
                    };
                    _ihangServices.Add(hang);
                    loadHang();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }      

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TenNSX.Text = "";
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

        private void dgv_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _hang.Count)
            {
                return;
            }
            var doituongcellclick = _hang[index];
            _idcellclick = doituongcellclick.MaHSX;
            txt_TenNSX.Text = doituongcellclick.TenHSX;
            rb_HoatDong.Checked = doituongcellclick.TrangThaiHSX == true;
            rb_KHD.Checked = doituongcellclick.TrangThaiHSX == false;
        }

        private void FrmHang_Load(object sender, EventArgs e)
        {
            loadHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                var resultsua = _ihangServices.Update((Guid)_idcellclick, new HangSX()
                {
                    TenHSX = txt_TenNSX.Text,
                    TrangThaiHSX = rb_HoatDong.Checked
                });

                if (resultsua)
                {
                    MessageBox.Show("Sửa thành công");
                    loadHang();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
        }
    }
}
    
