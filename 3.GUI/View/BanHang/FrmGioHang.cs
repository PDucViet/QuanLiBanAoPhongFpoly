﻿using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
namespace _3.GUI.View.BanHang
{
    public partial class FrmGioHang : Form
    {

        private IQLsanPhamChiTietServices _qlSanPhamCT;
        private IQLhoaDonChiTietServices _qlhoaDonChiTiet;
        private IQLhoaDonServices _qlhoaDon;
        private IQLkhachHangServices _qlKhachHang;
        public List<ViewHoaDonCT> _lstViewHoaDon;
        private IQLhangSXServices _qlNSX;
        private IQLsizeServices _qlsize;
        private IQLsanPhamServices _qlSanPham;
        private IQLmauSacServices _qlMausac;
        public int pID;
        public khachHang KH;
        public int oID;
        public FrmGioHang()
        {
            InitializeComponent();
            _qlMausac = new QLmauSacServices();
            _qlNSX = new QLhangSXServices();
            _qlsize = new QLsizeServices();
            _qlSanPham = new QLsanPhamServices();
            _qlSanPhamCT = new QLsanPhamChiTietServices();
            _qlhoaDonChiTiet = new QLhoaDonChiTietServices();
            _qlhoaDon = new QLhoaDonServices();
            _qlKhachHang = new QLkhachHangServices();
            _lstViewHoaDon = new List<ViewHoaDonCT>();
            KH = new khachHang();
            oID = -1;
            LoadSanPham();
            loadHDcho();
        }

        public void LoadSanPham()
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qlSanPhamCT.getViewSanPhamCT())
            {
                dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
            }
        }
        public void loadGioHang()
        {
            dtgv_gioHang.Rows.Clear();
            foreach (var item in _lstViewHoaDon)
            {
                dtgv_gioHang.Rows.Add(item.ID, item.tenSanPham, item.soLuong, item.donGia);
            }
            TONGTIEN();
        }
        public void loadHDcho()
        {
            dtgv_HDcho.Rows.Clear();
            var hdCho = _qlhoaDon.getViewhoaDon().Where(x => x.hoaDons.trangThai == false);
            foreach (var item in hdCho)
            {
                dtgv_HDcho.Rows.Add(item.hoaDons.IDHoaDon, item.khachHangs.TenKH);
            }
        }
        public void themGioHang(int pID)
        {
            var p = _qlSanPhamCT.getViewSanPhamCT().FirstOrDefault(x => x.SanPhamChiTiets.IDSanPhamChiTiet == pID);
            var data = _lstViewHoaDon.FirstOrDefault(x => x.ID == p.SanPhamChiTiets.IDSanPhamChiTiet);
            if (p.SanPhamChiTiets.Soluong <= 0)
            {
                MessageBox.Show("Hết hàng ");
            }
            else if (data == null)
            {
                ViewHoaDonCT viewHDCT = new ViewHoaDonCT()
                {
                    ID = p.SanPhamChiTiets.IDSanPhamChiTiet,
                    tenSanPham = p.SanPhamChiTiets.TenSP,
                    donGia = p.SanPhamChiTiets.Giaban,
                    soLuong = 1,
                    maSanPham = p.SanPhamChiTiets.maSP
                };
                _lstViewHoaDon.Add(viewHDCT);
            }
            else
            {
                if (data.soLuong == p.SanPhamChiTiets.Soluong)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.soLuong++;
                }
            }
            loadGioHang();
        }

        public void ResetForm()
        {
            tbt_maHD.Text = "";
            tbt_giamGia.Text = "";
            tbt_tienKhachDua.Text = "";
            lbl_Diem.Text = "";
            lbl_TienThua.Text = "";
            lbl_Tong.Text = "";
            lbl_tongTien.Text = "";
        }
        private void dtgv_gioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                if (e.ColumnIndex == 2)
                {
                    if (int.TryParse(dtgv_gioHang.Rows[r.Index].Cells[2].Value.ToString(), out int x))
                    {
                        if (dtgv_gioHang.Rows[r.Index].Cells[2].Value != _lstViewHoaDon[r.Index].soLuong.ToString())
                        {
                            if (Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value) <= 0)
                            {
                                MessageBox.Show("Nhập sai số lượng");
                                dtgv_gioHang.Rows[r.Index].Cells[2].Value = _lstViewHoaDon[r.Index].soLuong;
                            }
                            else
                            {
                                var p = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == _lstViewHoaDon[r.Index].ID);
                                if (p.Soluong < Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value))
                                {
                                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                    dtgv_gioHang.Rows[r.Index].Cells[2].Value = _lstViewHoaDon[r.Index].soLuong;
                                }
                                else
                                {
                                    _lstViewHoaDon[r.Index].soLuong = Convert.ToInt32(dtgv_gioHang.Rows[r.Index].Cells[2].Value);
                                    TONGTIEN();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai số lượng");
                        dtgv_gioHang.Rows[r.Index].Cells[3].Value = _lstViewHoaDon[r.Index].soLuong;
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ được sửa cột nào khác ngoài cột số lượng.");
                    loadGioHang();
                }
            }
        }

        private void dtgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_sanPham.Rows[e.RowIndex];
                pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                themGioHang(pID);
            }
        }

        private void dtgv_gioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
                pID = Convert.ToInt32(r.Cells[0].Value.ToString());
            }
        }

        private void tbt_maHD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_maHD.Text, out int m))
            {
                hoaDon o = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == Convert.ToInt32(tbt_maHD.Text) && x.trangThai == false);
                if (o != null)
                {
                    lbl_Tong.Text = o.tongTien.ToString();
                    var khach = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == o.SDT_KH);
                    lbl_giamGia.Text = $"(Tối đa : {khach.diem})";
                }
                else
                {
                    lbl_Tong.Text = "0";
                    lbl_giamGia.Text = "Tối đa : 0";
                }
            }
        }

        private void btn_xoaSP_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                var item = _lstViewHoaDon.FirstOrDefault(x => x.ID == pID);
                _lstViewHoaDon.Remove(item);
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_xoaGioHang_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                _lstViewHoaDon = new List<ViewHoaDonCT>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if (_lstViewHoaDon.Any())
            {
                float Tong = 0;
                foreach (var item in _lstViewHoaDon)
                {
                    Tong += item.donGia * item.soLuong;
                }
                KH = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);

                if (KH != null)
                {
                    hoaDon HD = new hoaDon()
                    {
                        IDNhanVien = 1,
                        SDT_KH = KH.SDT_KH,
                        ngayBan = DateTime.Now,
                        tongTien = Tong,
                        trangThai = false,
                        ghiChu = ""
                    };
                    _qlhoaDon.addHoaDon(HD);
                    foreach (var item in _lstViewHoaDon)
                    {
                        hoaDonChiTiet od = new hoaDonChiTiet()
                        {
                            IDHoaDon = HD.IDHoaDon,
                            IDSanPham = item.ID,
                            donGia = item.donGia,
                            Soluong = item.soLuong
                        };
                        _qlhoaDonChiTiet.addHoaDonChiTiet(od);
                        var p = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.ID);
                        //if (p.Soluong <= 0)
                        //{
                        //    MessageBox.Show("Hết hàng");
                        //}
                        //else
                        //{
                        p.Soluong -= item.soLuong;
                        _qlSanPhamCT.UpdateSanPham(p);
                        //}


                    }

                    //tbt_maHD.Text = HD.IDHoaDon.ToString();
                    //lbl_Tong.Text = HD.tongTien.ToString();
                    //lbl_tongTien.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {HD.IDHoaDon}");
                    loadHDcho();
                    _lstViewHoaDon = new List<ViewHoaDonCT>();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            if (oID != -1)
            {
                if (_lstViewHoaDon.Any())
                {
                    int Tien = 0;
                    KH = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);
                    if (KH != null)
                    {
                        var HD = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == oID);
                        var HDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == oID);
                        foreach (var item in HDCT)
                        {
                            _qlhoaDonChiTiet.RemoveHoaDonChiTiet(item);
                        }


                        foreach (var item in _lstViewHoaDon)
                        {
                            hoaDonChiTiet hoaDonChi = new hoaDonChiTiet()
                            {
                                IDHoaDon = oID,
                                IDSanPham = item.ID,
                                donGia = item.donGia,
                                Soluong = item.soLuong
                            };
                            Tien += Convert.ToInt32(item.donGia * item.soLuong);
                            _qlhoaDonChiTiet.addHoaDonChiTiet(hoaDonChi);
                            var SP = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.ID);
                            SP.Soluong -= item.soLuong;
                            _qlSanPhamCT.UpdateSanPham(SP);
                        }

                        HD.ngayBan = DateTime.Now;
                        HD.SDT_KH = KH.SDT_KH;
                        HD.tongTien = Tien;
                        _qlhoaDon.UpdateHoaDon(HD);

                        tbt_maHD.Text = oID.ToString();
                        lbl_tongTien.Text = Tien.ToString();
                        tbt_SDT.Text = "";
                        lbl_Tong.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {oID}");
                        oID = -1;
                        loadHDcho();
                        dtgv_gioHang.Rows.Clear();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

        private void dtgv_HDcho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_HDcho.Rows[e.RowIndex];
                oID = Convert.ToInt32(r.Cells[0].Value.ToString());
                tbt_maHD.Text = oID.ToString();

                var HDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == oID);
                var HD = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == oID).SDT_KH;
                var KH = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HD);
                tbt_SDT.Text = KH.SDT_KH;

                _lstViewHoaDon = new List<ViewHoaDonCT>();
                foreach (var item in HDCT)
                {
                    var SP = _qlSanPhamCT.GetSanPhamCTTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.IDSanPham);

                    ViewHoaDonCT ViewHDCT = new ViewHoaDonCT()
                    {
                        ID = SP.IDSanPhamChiTiet,
                        tenSanPham = SP.TenSP,
                        donGia = SP.Giaban,
                        soLuong = HDCT.FirstOrDefault(x => x.IDSanPham == SP.IDSanPhamChiTiet).Soluong
                    };
                    _lstViewHoaDon.Add(ViewHDCT);

                    loadGioHang();
                }
            }
        }

        public void TONGTIEN()
        {
            if (_lstViewHoaDon != null)
            {
                int Tien = 0;
                foreach (var item in _lstViewHoaDon)
                {
                    Tien += Convert.ToInt32(item.donGia) * item.soLuong;
                }
                lbl_tongTien.Text = Tien.ToString();
            }
            else
            {
                lbl_tongTien.Text = "";
            }
        }

        public void loadTienThua()
        {
            if (!(tbt_tienKhachDua.Text == "" && tbt_giamGia.Text == ""))
            {
                if (tbt_giamGia.Text == "")
                {
                    if (float.TryParse(tbt_tienKhachDua.Text, out float x))
                    {

                        lbl_TienThua.Text = (float.Parse(tbt_tienKhachDua.Text) - float.Parse(lbl_Tong.Text)).ToString();

                    }
                }
                else
                {
                    if (float.TryParse(tbt_tienKhachDua.Text, out float x) && float.TryParse(tbt_giamGia.Text, out float y))
                    {

                        lbl_TienThua.Text = (float.Parse(tbt_tienKhachDua.Text) - float.Parse(lbl_Tong.Text) + float.Parse(tbt_giamGia.Text)).ToString();

                    }
                }
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            hoaDon HD = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(p => Convert.ToString(p.IDHoaDon) == tbt_maHD.Text && p.trangThai == false);
            if (HD == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                lbl_tongTien.Text = "0";
            }
            else if (tbt_maHD.Text == "")
            {
                MessageBox.Show("Đơn hàng không tồn tại");
            }
            else
            {
                var KhachH = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HD.SDT_KH);
                int x;
                if (tbt_giamGia.Text == "" || float.Parse(tbt_giamGia.Text) < 0 || float.Parse(lbl_TienThua.Text) < 0 || tbt_tienKhachDua.Text == "" || (!float.TryParse(tbt_giamGia.Text, out float z) && tbt_giamGia.Text != "") || !float.TryParse(tbt_tienKhachDua.Text, out float y) || float.Parse(tbt_giamGia.Text) > float.Parse(lbl_tongTien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HD.trangThai = true;
                        _qlhoaDon.UpdateHoaDon(HD);
                        if (tbt_tienKhachDua.Text == "0" && float.Parse(tbt_giamGia.Text) > HD.tongTien)
                        {
                            lbl_TienThua.Text = "0";
                            KhachH.diem -= Convert.ToInt32(HD.tongTien);
                        }
                        else
                        {
                            if (tbt_giamGia.Text != "")
                            {
                                KhachH.diem = KhachH.diem + Convert.ToInt32((HD.tongTien * 10) / 100) - Convert.ToInt32(tbt_giamGia.Text);
                            }
                            else
                            {
                                KhachH.diem += Convert.ToInt32((HD.tongTien * 10) / 100);
                            }
                        }
                        _qlKhachHang.UpdateKhachHang(KhachH);
                        MessageBox.Show("Thanh toán thành công");
                        tbt_maHD.Text = "";
                        tbt_SDT.Text = "";
                        tbt_giamGia.Text = "";
                        lbl_giamGia.Text = "";
                        tbt_tienKhachDua.Text = "";
                        lbl_Tong.Text = "";
                        lbl_tongTien.Text = "";
                        lbl_TienThua.Text = "0";
                        tbt_ghiChu.Text = "";
                        _lstViewHoaDon = new List<ViewHoaDonCT>();
                        loadGioHang();
                        loadHDcho();
                        LoadSanPham();
                    }
                }
            }

        }

        private void tbt_tienKhachDua_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void tbt_giamGia_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void tbt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_SDT.Text, out int x))
            {
                KH = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == tbt_SDT.Text);
                if (KH != null)
                {
                    lbl_tenKhach.Text = KH.TenKH;
                    lbl_Diem.Text = KH.diem.ToString();
                }
                else
                {
                    lbl_tenKhach.Text = "";
                    lbl_Diem.Text = "";
                }
            }
            else
            {
                lbl_tenKhach.Text = "";
                lbl_Diem.Text = "";
            }
        }
        private void senderexcel(string path)
        {
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Báo cáo thống kê";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("sheet");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                // đặt tên cho sheet
                ws.Name = "sheet";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                for (int i = 0; i < dtgv_HDcho.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dtgv_HDcho.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_HDcho.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_HDcho.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dtgv_HDcho.Rows[i].Cells[j].Value;
                    }
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);

                /*excel.Application application = new excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dtgv_HDcho.Columns.Count; i++)
                {
                    application.Cells[1, i + 1] = dtgv_HDcho.Columns[i].HeaderText;
                }
                for (int i = 0; i < dtgv_HDcho.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_HDcho.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dtgv_HDcho.Rows[i].Cells[j].Value;
                    }
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;*/
            };
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    senderexcel(filePath);
                    MessageBox.Show("Xuất File Excel Thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xuất File Excel không  Thành công" + ex.Message);
                }
            }
            //InHoaDon();
        }

        //private void cbb_NSX_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbb_NSX.Text == "Tất cả")
        //    {
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in _qlSanPhamCT.getViewSanPhamCT())
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP,
        //                item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //    else
        //    {
        //        var timNSX = _qlSanPhamCT.getViewSanPhamCT().Where(p => p.hangSXs.tenHangSX == cbb_NSX.Text);
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in timNSX)
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe,
        //                item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //}

        //private void cbb_size_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbb_size.Text == "Tất cả")
        //    {
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in _qlSanPhamCT.getViewSanPhamCT())
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau,
        //                item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //    else
        //    {
        //        var timsize = _qlSanPhamCT.getViewSanPhamCT().Where(p => p.sizes.SiZe == cbb_size.Text);
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in timsize)
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP,
        //                item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //}

        //private void cbb_Mau_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbb_Mau.Text == "Tất cả")
        //    {
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in _qlSanPhamCT.getViewSanPhamCT())
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP,
        //                item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //    else
        //    {
        //        var timMau = _qlSanPhamCT.getViewSanPhamCT().Where(p => p.mauSacs.tenMau == cbb_Mau.Text);
        //        dtgv_sanPham.Rows.Clear();
        //        foreach (var item in timMau)
        //        {
        //            dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP,
        //                item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //        }
        //    }
        //}

        //private void tbt_timKiem_TextChanged(object sender, EventArgs e)
        //{
        //    dtgv_sanPham.Rows.Clear();
        //    foreach (var item in _qlSanPhamCT.getViewSanPhamCT().Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(tbt_timKiem.Text) || x.SanPhamChiTiets.maSP.ToLower().Contains(tbt_timKiem.Text.ToLower())
        //    || x.mauSacs.tenMau.ToLower().Contains(tbt_timKiem.Text) || x.hangSXs.tenHangSX.ToLower().Contains(tbt_timKiem.Text)
        //    || x.sizes.SiZe.ToLower().Contains(tbt_timKiem.Text) || x.sanPhams.tenLoaiHang.ToLower().Contains(tbt_timKiem.Text)
        //    || Convert.ToString(x.SanPhamChiTiets.IDsanPham).Contains(tbt_timKiem.Text)))
        //    {
        //        dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
        //    }
        //}

        private void tbt_timKiem_TextChanged_1(object sender, EventArgs e)
        {
            dtgv_sanPham.Rows.Clear();
            foreach (var item in _qlSanPhamCT.getViewSanPhamCT().Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(tbt_timKiem.Text) || x.SanPhamChiTiets.maSP.ToLower().Contains(tbt_timKiem.Text.ToLower())
            || x.mauSacs.tenMau.ToLower().Contains(tbt_timKiem.Text) || x.hangSXs.tenHangSX.ToLower().Contains(tbt_timKiem.Text)
            || x.sizes.SiZe.ToLower().Contains(tbt_timKiem.Text) || x.sanPhams.tenLoaiHang.ToLower().Contains(tbt_timKiem.Text)
            || Convert.ToString(x.SanPhamChiTiets.IDsanPham).Contains(tbt_timKiem.Text)))
            {
                dtgv_sanPham.Rows.Add(item.SanPhamChiTiets.IDSanPhamChiTiet, item.SanPhamChiTiets.maSP, item.SanPhamChiTiets.TenSP, item.mauSacs.tenMau, item.sizes.SiZe, item.SanPhamChiTiets.Giaban, item.hangSXs.tenHangSX, item.SanPhamChiTiets.Soluong);
            }
        }
        //private void InHoaDon()
        //{
        //    pddhd.Document = pdhoadon;
        //    pddhd.ShowDialog();
        //}

        //private void pdhoadon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    //var hd = _hoaDonChiTiet.GetHoaDonChiTietFromDB().SingleOrDefault(x => x.IDHoaDon == Convert.ToInt32(tbt_maHD.Text));
        //    var w = pdhoadon.DefaultPageSettings.PaperSize.Width;
        //    e.Graphics.DrawString("Shop Bán quần áo",
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black, new Point(100, 20)
        //        );
        //    e.Graphics.DrawString(
        //        String.Format("HD{0}", hoaDonChiTiet.IDHoaDon),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new PointF(w / 2 + 200, 20));
        //    e.Graphics.DrawString(
        //       String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
        //       new Font("Courier New", 12, FontStyle.Bold),
        //       Brushes.Black,
        //       new PointF(w / 2 + 200, 45));
        //    e.Graphics.DrawString(
        //        String.Format("Tòa nhà P , CĐ FPTPOLYTECHNNIC"),
        //        new Font("Courier New", 8, FontStyle.Bold),
        //        Brushes.Black,
        //        new PointF(100, 45));
        //    var y = 70;
        //    Pen blackpen = new Pen(Color.Black,1);
        //    Point p1 = new Point(10, y);
        //    Point p2 = new Point(w - 10, y);
        //    e.Graphics.DrawLine(blackpen, p1, p2);
        //    //e.Graphics.DrawString(String.Format("Tên sản phẩm : ", hoaDonChiTiet.sanPham), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(100, 20));
        //}
    }
}
