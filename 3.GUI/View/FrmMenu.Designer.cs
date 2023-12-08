namespace _3.GUI.View
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelMenu = new Panel();
            submenu = new Panel();
            btn_sp = new Button();
            btn_nsx = new Button();
            btn_ms = new Button();
            btn_size = new Button();
            button6 = new Button();
            btn_thongke = new Button();
            button1 = new Button();
            btn_nhanvien = new Button();
            btn_khachhang = new Button();
            btn_hoadon = new Button();
            btn_buy = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            panelHome = new Panel();
            btn_closechildform = new Button();
            lb_home = new Label();
            panelmanchinh = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            submenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHome.SuspendLayout();
            panelmanchinh.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(submenu);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(btn_thongke);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btn_nhanvien);
            panelMenu.Controls.Add(btn_khachhang);
            panelMenu.Controls.Add(btn_hoadon);
            panelMenu.Controls.Add(btn_buy);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 584);
            panelMenu.TabIndex = 0;
            // 
            // submenu
            // 
            submenu.Controls.Add(btn_sp);
            submenu.Controls.Add(btn_nsx);
            submenu.Controls.Add(btn_ms);
            submenu.Controls.Add(btn_size);
            submenu.Location = new Point(35, 334);
            submenu.Margin = new Padding(3, 2, 3, 2);
            submenu.Name = "submenu";
            submenu.Size = new Size(215, 207);
            submenu.TabIndex = 16;
            submenu.Visible = false;
            submenu.Paint += submenu_Paint;
            // 
            // btn_sp
            // 
            btn_sp.FlatAppearance.BorderSize = 0;
            btn_sp.FlatStyle = FlatStyle.Flat;
            btn_sp.ForeColor = Color.Gainsboro;
            btn_sp.Location = new Point(3, -2);
            btn_sp.Margin = new Padding(3, 2, 3, 2);
            btn_sp.Name = "btn_sp";
            btn_sp.Padding = new Padding(10, 0, 0, 0);
            btn_sp.Size = new Size(169, 45);
            btn_sp.TabIndex = 10;
            btn_sp.Text = "  Sản phẩm";
            btn_sp.TextAlign = ContentAlignment.MiddleLeft;
            btn_sp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sp.UseVisualStyleBackColor = true;
            btn_sp.Click += btn_sp_Click_1;
            // 
            // btn_nsx
            // 
            btn_nsx.FlatAppearance.BorderSize = 0;
            btn_nsx.FlatStyle = FlatStyle.Flat;
            btn_nsx.ForeColor = Color.Gainsboro;
            btn_nsx.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nsx.Location = new Point(3, 93);
            btn_nsx.Margin = new Padding(3, 2, 3, 2);
            btn_nsx.Name = "btn_nsx";
            btn_nsx.Padding = new Padding(10, 0, 0, 0);
            btn_nsx.Size = new Size(169, 45);
            btn_nsx.TabIndex = 11;
            btn_nsx.Text = "Nhà sản xuất";
            btn_nsx.TextAlign = ContentAlignment.MiddleLeft;
            btn_nsx.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nsx.UseVisualStyleBackColor = true;
            btn_nsx.Click += btn_nsx_Click_1;
            // 
            // btn_ms
            // 
            btn_ms.FlatAppearance.BorderSize = 0;
            btn_ms.FlatStyle = FlatStyle.Flat;
            btn_ms.ForeColor = Color.Gainsboro;
            btn_ms.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ms.Location = new Point(3, 142);
            btn_ms.Margin = new Padding(3, 2, 3, 2);
            btn_ms.Name = "btn_ms";
            btn_ms.Padding = new Padding(10, 0, 0, 0);
            btn_ms.Size = new Size(169, 45);
            btn_ms.TabIndex = 9;
            btn_ms.Text = "  Màu sắc";
            btn_ms.TextAlign = ContentAlignment.MiddleLeft;
            btn_ms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ms.UseVisualStyleBackColor = true;
            btn_ms.Click += btn_ms_Click_1;
            // 
            // btn_size
            // 
            btn_size.FlatAppearance.BorderSize = 0;
            btn_size.FlatStyle = FlatStyle.Flat;
            btn_size.ForeColor = Color.Gainsboro;
            btn_size.ImageAlign = ContentAlignment.MiddleLeft;
            btn_size.Location = new Point(3, 44);
            btn_size.Margin = new Padding(3, 2, 3, 2);
            btn_size.Name = "btn_size";
            btn_size.Padding = new Padding(10, 0, 0, 0);
            btn_size.Size = new Size(169, 45);
            btn_size.TabIndex = 10;
            btn_size.Text = "  Size";
            btn_size.TextAlign = ContentAlignment.MiddleLeft;
            btn_size.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_size.UseVisualStyleBackColor = true;
            btn_size.Click += btn_size_Click_1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Gainsboro;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 285);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(192, 45);
            button6.TabIndex = 15;
            button6.Text = "  Sản phẩm";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.Dock = DockStyle.Top;
            btn_thongke.FlatAppearance.BorderSize = 0;
            btn_thongke.FlatStyle = FlatStyle.Flat;
            btn_thongke.ForeColor = Color.Gainsboro;
            btn_thongke.Image = (Image)resources.GetObject("btn_thongke.Image");
            btn_thongke.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongke.Location = new Point(0, 240);
            btn_thongke.Margin = new Padding(3, 2, 3, 2);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Padding = new Padding(10, 0, 0, 0);
            btn_thongke.Size = new Size(192, 45);
            btn_thongke.TabIndex = 14;
            btn_thongke.Text = "  Thống kê";
            btn_thongke.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_thongke.UseVisualStyleBackColor = true;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 51, 76);
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 539);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(192, 45);
            button1.TabIndex = 6;
            button1.Text = "Đăng xuất";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.Dock = DockStyle.Top;
            btn_nhanvien.FlatAppearance.BorderSize = 0;
            btn_nhanvien.FlatStyle = FlatStyle.Flat;
            btn_nhanvien.ForeColor = Color.Gainsboro;
            btn_nhanvien.Image = (Image)resources.GetObject("btn_nhanvien.Image");
            btn_nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nhanvien.Location = new Point(0, 195);
            btn_nhanvien.Margin = new Padding(3, 2, 3, 2);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Padding = new Padding(10, 0, 0, 0);
            btn_nhanvien.Size = new Size(192, 45);
            btn_nhanvien.TabIndex = 3;
            btn_nhanvien.Text = "  Nhân Viên";
            btn_nhanvien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nhanvien.UseVisualStyleBackColor = true;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.FlatAppearance.BorderSize = 0;
            btn_khachhang.FlatStyle = FlatStyle.Flat;
            btn_khachhang.ForeColor = Color.Gainsboro;
            btn_khachhang.Image = (Image)resources.GetObject("btn_khachhang.Image");
            btn_khachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khachhang.Location = new Point(0, 150);
            btn_khachhang.Margin = new Padding(3, 2, 3, 2);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Padding = new Padding(10, 0, 0, 0);
            btn_khachhang.Size = new Size(192, 45);
            btn_khachhang.TabIndex = 2;
            btn_khachhang.Text = "  Khách Hàng";
            btn_khachhang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_khachhang.UseVisualStyleBackColor = true;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Dock = DockStyle.Top;
            btn_hoadon.FlatAppearance.BorderSize = 0;
            btn_hoadon.FlatStyle = FlatStyle.Flat;
            btn_hoadon.ForeColor = Color.Gainsboro;
            btn_hoadon.Image = (Image)resources.GetObject("btn_hoadon.Image");
            btn_hoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoadon.Location = new Point(0, 105);
            btn_hoadon.Margin = new Padding(3, 2, 3, 2);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Padding = new Padding(10, 0, 0, 0);
            btn_hoadon.Size = new Size(192, 45);
            btn_hoadon.TabIndex = 1;
            btn_hoadon.Text = "  Hóa Đơn";
            btn_hoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hoadon.UseVisualStyleBackColor = true;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_buy
            // 
            btn_buy.Dock = DockStyle.Top;
            btn_buy.FlatAppearance.BorderSize = 0;
            btn_buy.FlatStyle = FlatStyle.Flat;
            btn_buy.ForeColor = Color.Gainsboro;
            btn_buy.Image = (Image)resources.GetObject("btn_buy.Image");
            btn_buy.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buy.Location = new Point(0, 60);
            btn_buy.Margin = new Padding(3, 2, 3, 2);
            btn_buy.Name = "btn_buy";
            btn_buy.Padding = new Padding(10, 0, 0, 0);
            btn_buy.Size = new Size(192, 45);
            btn_buy.TabIndex = 0;
            btn_buy.Text = "  Bán Hàng";
            btn_buy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buy.UseVisualStyleBackColor = true;
            btn_buy.Click += btn_buy_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 0, 0);
            panelLogo.Size = new Size(192, 60);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÍ BÁN HÀNG";
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.DeepSkyBlue;
            panelHome.Controls.Add(btn_closechildform);
            panelHome.Controls.Add(lb_home);
            panelHome.Dock = DockStyle.Top;
            panelHome.Location = new Point(192, 0);
            panelHome.Margin = new Padding(3, 2, 3, 2);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1147, 60);
            panelHome.TabIndex = 0;
            // 
            // btn_closechildform
            // 
            btn_closechildform.Dock = DockStyle.Left;
            btn_closechildform.FlatAppearance.BorderSize = 0;
            btn_closechildform.FlatStyle = FlatStyle.Flat;
            btn_closechildform.Image = Properties.Resources.icons8_multiply_64;
            btn_closechildform.Location = new Point(0, 0);
            btn_closechildform.Margin = new Padding(3, 2, 3, 2);
            btn_closechildform.Name = "btn_closechildform";
            btn_closechildform.Size = new Size(82, 60);
            btn_closechildform.TabIndex = 0;
            btn_closechildform.UseVisualStyleBackColor = true;
            btn_closechildform.Click += btn_closechildform_Click;
            // 
            // lb_home
            // 
            lb_home.Anchor = AnchorStyles.None;
            lb_home.AutoSize = true;
            lb_home.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_home.ForeColor = SystemColors.ButtonHighlight;
            lb_home.Location = new Point(535, 16);
            lb_home.Name = "lb_home";
            lb_home.Size = new Size(78, 26);
            lb_home.TabIndex = 0;
            lb_home.Text = "HOME";
            // 
            // panelmanchinh
            // 
            panelmanchinh.Controls.Add(panel1);
            panelmanchinh.Dock = DockStyle.Fill;
            panelmanchinh.Location = new Point(192, 60);
            panelmanchinh.Margin = new Padding(3, 2, 3, 2);
            panelmanchinh.Name = "panelmanchinh";
            panelmanchinh.Size = new Size(1147, 524);
            panelmanchinh.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 524);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(678, 348);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 10;
            label5.Text = "Chủ cửa hàng : Nhóm 6";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(668, 379);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại : 0999999999";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 406);
            label3.Name = "label3";
            label3.Size = new Size(384, 15);
            label3.TabIndex = 8;
            label3.Text = "Địa chỉ : Cao Đẳng FPTPOLYTECHNIC , Kiều Mai , Nam Từ Liêm , Hà Nội";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(578, 45);
            label1.Name = "label1";
            label1.Size = new Size(357, 45);
            label1.TabIndex = 7;
            label1.Text = "SHOP ÁO PHÔNG POLY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._317502577_671965111066981_3787928448780715536_n;
            pictureBox1.Location = new Point(609, 95);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 226);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 584);
            Controls.Add(panelmanchinh);
            Controls.Add(panelHome);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "FrmMenu";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            panelMenu.ResumeLayout(false);
            submenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            panelmanchinh.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btn_nhanvien;
        private Button btn_khachhang;
        private Button btn_hoadon;
        private Button btn_buy;
        private Panel panelLogo;
        private Panel panelHome;
        private Label lb_home;
        private Label label2;
        private Panel panelmanchinh;
        private Button btn_closechildform;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_thongke;
        private Panel submenu;
        private Button btn_sp;
        private Button btn_nsx;
        private Button btn_ms;
        private Button btn_size;
        private Button button6;
    }
}