namespace C.PL.Forms
{
    partial class FrmGioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGioHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDanhSachSp = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.btnTruSoLuong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtTienThua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnThanhToanAlllllllllll = new System.Windows.Forms.Button();
            this.btnThemVaoHoaDonCho = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbSDT = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.dgvHoaDonCho = new System.Windows.Forms.DataGridView();
            this.maSanPhamGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPhamGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauSacGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSXGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatLieuGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tru = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonCho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvDanhSachSp);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 308);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tìm kiếm :";
            // 
            // dgvDanhSachSp
            // 
            this.dgvDanhSachSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDanhSachSp.Location = new System.Drawing.Point(6, 59);
            this.dgvDanhSachSp.Name = "dgvDanhSachSp";
            this.dgvDanhSachSp.RowHeadersWidth = 51;
            this.dgvDanhSachSp.RowTemplate.Height = 29;
            this.dgvDanhSachSp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSp.Size = new System.Drawing.Size(970, 243);
            this.dgvDanhSachSp.TabIndex = 7;
            this.dgvDanhSachSp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSp_CellClick);
            this.dgvDanhSachSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSp_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Màu sắc";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Size";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "HangSX";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Chất liệu";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Trạng Thái Áo Phông CT";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(600, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên sản phẩm";
            this.txtTimKiem.Size = new System.Drawing.Size(376, 27);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.btnXoaGioHang);
            this.groupBox1.Controls.Add(this.btnTruSoLuong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dgvGioHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 288);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(607, 227);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 55);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.Location = new System.Drawing.Point(457, 227);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(135, 55);
            this.btnXoaGioHang.TabIndex = 11;
            this.btnXoaGioHang.Text = "Xóa giỏ hàng";
            this.btnXoaGioHang.UseVisualStyleBackColor = true;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // btnTruSoLuong
            // 
            this.btnTruSoLuong.Location = new System.Drawing.Point(147, 227);
            this.btnTruSoLuong.Name = "btnTruSoLuong";
            this.btnTruSoLuong.Size = new System.Drawing.Size(135, 55);
            this.btnTruSoLuong.TabIndex = 10;
            this.btnTruSoLuong.Text = "Trừ số lượng(-1)";
            this.btnTruSoLuong.UseVisualStyleBackColor = true;
            this.btnTruSoLuong.Click += new System.EventHandler(this.btnTruSoLuong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 55);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPhamGH,
            this.TenSanPhamGH,
            this.giaBanGH,
            this.soLuongGH,
            this.thanhTienGH,
            this.mauSacGH,
            this.sizeGH,
            this.hangSXGH,
            this.chatLieuGH,
            this.Column11,
            this.Tru,
            this.Xoa});
            this.dgvGioHang.Location = new System.Drawing.Point(6, 26);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGioHang.RowTemplate.Height = 29;
            this.dgvGioHang.Size = new System.Drawing.Size(736, 195);
            this.dgvGioHang.TabIndex = 8;
            this.dgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTienKhachDua);
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtTienThua);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1000, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 308);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(142, 120);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(201, 27);
            this.txtTienKhachDua.TabIndex = 26;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(142, 235);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "Nhập tên sản phẩm";
            this.txtGhiChu.Size = new System.Drawing.Size(201, 64);
            this.txtGhiChu.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ghi chú :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Location = new System.Drawing.Point(142, 77);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(133, 20);
            this.txtTongTien.TabIndex = 22;
            this.txtTongTien.Text = "ThongTinThongTin";
            // 
            // txtTienThua
            // 
            this.txtTienThua.AutoSize = true;
            this.txtTienThua.Location = new System.Drawing.Point(142, 179);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(133, 20);
            this.txtTienThua.TabIndex = 21;
            this.txtTienThua.Text = "ThongTinThongTin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tiền thừa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tiền khách đưa :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnThanhToanAlllllllllll);
            this.groupBox6.Controls.Add(this.btnThemVaoHoaDonCho);
            this.groupBox6.Controls.Add(this.btnXoaHoaDon);
            this.groupBox6.Location = new System.Drawing.Point(349, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 308);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // btnThanhToanAlllllllllll
            // 
            this.btnThanhToanAlllllllllll.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThanhToanAlllllllllll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThanhToanAlllllllllll.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToanAlllllllllll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToanAlllllllllll.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToanAlllllllllll.Image")));
            this.btnThanhToanAlllllllllll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhToanAlllllllllll.Location = new System.Drawing.Point(6, 215);
            this.btnThanhToanAlllllllllll.Name = "btnThanhToanAlllllllllll";
            this.btnThanhToanAlllllllllll.Size = new System.Drawing.Size(125, 87);
            this.btnThanhToanAlllllllllll.TabIndex = 15;
            this.btnThanhToanAlllllllllll.Text = "Thanh toán";
            this.btnThanhToanAlllllllllll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThanhToanAlllllllllll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhToanAlllllllllll.UseVisualStyleBackColor = false;
            // 
            // btnThemVaoHoaDonCho
            // 
            this.btnThemVaoHoaDonCho.Location = new System.Drawing.Point(6, 88);
            this.btnThemVaoHoaDonCho.Name = "btnThemVaoHoaDonCho";
            this.btnThemVaoHoaDonCho.Size = new System.Drawing.Size(125, 50);
            this.btnThemVaoHoaDonCho.TabIndex = 14;
            this.btnThemVaoHoaDonCho.Text = "Thêm vào hóa đơn chờ";
            this.btnThemVaoHoaDonCho.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(6, 26);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(125, 50);
            this.btnXoaHoaDon.TabIndex = 13;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Location = new System.Drawing.Point(142, 37);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(133, 20);
            this.txtThanhTien.TabIndex = 16;
            this.txtThanhTien.Text = "ThongTinThongTin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành tiền :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbSDT);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.txtHoTen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(777, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 282);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khách hàng";
            // 
            // cbbSDT
            // 
            this.cbbSDT.FormattingEnabled = true;
            this.cbbSDT.Location = new System.Drawing.Point(12, 26);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(261, 28);
            this.cbbSDT.TabIndex = 31;
            this.cbbSDT.SelectedIndexChanged += new System.EventHandler(this.cbbSDT_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(73, 117);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(200, 159);
            this.txtDiaChi.TabIndex = 30;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(73, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(200, 27);
            this.txtHoTen.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Họ tên :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClearAll);
            this.groupBox5.Controls.Add(this.dgvHoaDonCho);
            this.groupBox5.Location = new System.Drawing.Point(1062, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(423, 282);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hóa đơn chờ";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(183, 227);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(166, 49);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDonCho
            // 
            this.dgvHoaDonCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonCho.Location = new System.Drawing.Point(6, 26);
            this.dgvHoaDonCho.Name = "dgvHoaDonCho";
            this.dgvHoaDonCho.RowHeadersWidth = 51;
            this.dgvHoaDonCho.RowTemplate.Height = 29;
            this.dgvHoaDonCho.Size = new System.Drawing.Size(411, 195);
            this.dgvHoaDonCho.TabIndex = 13;
            // 
            // maSanPhamGH
            // 
            this.maSanPhamGH.HeaderText = "Mã sản phẩm";
            this.maSanPhamGH.MinimumWidth = 6;
            this.maSanPhamGH.Name = "maSanPhamGH";
            // 
            // TenSanPhamGH
            // 
            this.TenSanPhamGH.HeaderText = "Tên sản phẩm";
            this.TenSanPhamGH.MinimumWidth = 6;
            this.TenSanPhamGH.Name = "TenSanPhamGH";
            // 
            // giaBanGH
            // 
            this.giaBanGH.HeaderText = "Giá bán";
            this.giaBanGH.MinimumWidth = 6;
            this.giaBanGH.Name = "giaBanGH";
            // 
            // soLuongGH
            // 
            this.soLuongGH.HeaderText = "Số lượng";
            this.soLuongGH.MinimumWidth = 6;
            this.soLuongGH.Name = "soLuongGH";
            // 
            // thanhTienGH
            // 
            this.thanhTienGH.HeaderText = "Thành tiền";
            this.thanhTienGH.MinimumWidth = 6;
            this.thanhTienGH.Name = "thanhTienGH";
            // 
            // mauSacGH
            // 
            this.mauSacGH.HeaderText = "Màu sắc";
            this.mauSacGH.MinimumWidth = 6;
            this.mauSacGH.Name = "mauSacGH";
            // 
            // sizeGH
            // 
            this.sizeGH.HeaderText = "Size";
            this.sizeGH.MinimumWidth = 6;
            this.sizeGH.Name = "sizeGH";
            // 
            // hangSXGH
            // 
            this.hangSXGH.HeaderText = "HangSX";
            this.hangSXGH.MinimumWidth = 6;
            this.hangSXGH.Name = "hangSXGH";
            // 
            // chatLieuGH
            // 
            this.chatLieuGH.HeaderText = "Chất liệu";
            this.chatLieuGH.MinimumWidth = 6;
            this.chatLieuGH.Name = "chatLieuGH";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Trạng thái";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Tru
            // 
            this.Tru.HeaderText = "Trừ";
            this.Tru.MinimumWidth = 6;
            this.Tru.Name = "Tru";
            this.Tru.Text = " -";
            this.Tru.ToolTipText = "Tru";
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xoa";
            this.Xoa.ToolTipText = "Xoa";
            // 
            // FrmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 630);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmGioHang";
            this.Text = "FrmGioHang";
            this.Load += new System.EventHandler(this.FrmGioHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonCho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private DataGridView dgvDanhSachSp;
        private GroupBox groupBox1;
        private Button btnThanhToan;
        private Button btnXoaGioHang;
        private Button btnTruSoLuong;
        private Button btnXoa;
        private DataGridView dgvGioHang;
        private GroupBox groupBox3;
        private Button btnXoaHoaDon;
        private Label label1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label9;
        private Label txtTongTien;
        private Label txtTienThua;
        private Label label6;
        private Label label5;
        private GroupBox groupBox6;
        private Label txtThanhTien;
        private Label label8;
        private Button btnClearAll;
        private DataGridView dgvHoaDonCho;
        private TextBox txtGhiChu;
        private Label label11;
        private Button btnThanhToanAlllllllllll;
        private Button btnThemVaoHoaDonCho;
        private TextBox txtTienKhachDua;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private Label label4;
        private Label label3;
        private ComboBox cbbSDT;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn maSanPhamGH;
        private DataGridViewTextBoxColumn TenSanPhamGH;
        private DataGridViewTextBoxColumn giaBanGH;
        private DataGridViewTextBoxColumn soLuongGH;
        private DataGridViewTextBoxColumn thanhTienGH;
        private DataGridViewTextBoxColumn mauSacGH;
        private DataGridViewTextBoxColumn sizeGH;
        private DataGridViewTextBoxColumn hangSXGH;
        private DataGridViewTextBoxColumn chatLieuGH;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewButtonColumn Tru;
        private DataGridViewButtonColumn Xoa;
    }
}