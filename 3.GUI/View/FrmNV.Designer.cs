namespace _3.GUI.View
{
    partial class FrmNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNV));
            label5 = new Label();
            tb_email = new TextBox();
            tb_sdt = new TextBox();
            tb_ten = new TextBox();
            tb_diachi = new TextBox();
            label4 = new Label();
            dtg_show = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            tb_matkhau = new TextBox();
            rd_khd = new RadioButton();
            rd_hd = new RadioButton();
            label6 = new Label();
            cbb_cv = new ComboBox();
            btn_xoahoadon = new Button();
            btn_sua = new Button();
            btn_hoadon = new Button();
            btn_tim = new Button();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 196);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 23;
            label5.Text = "Email";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(174, 190);
            tb_email.Margin = new Padding(3, 2, 3, 2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(155, 23);
            tb_email.TabIndex = 22;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(174, 146);
            tb_sdt.Margin = new Padding(3, 2, 3, 2);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(155, 23);
            tb_sdt.TabIndex = 20;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(174, 56);
            tb_ten.Margin = new Padding(3, 2, 3, 2);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(155, 23);
            tb_ten.TabIndex = 19;
            // 
            // tb_diachi
            // 
            tb_diachi.Location = new Point(174, 103);
            tb_diachi.Margin = new Padding(3, 2, 3, 2);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(155, 23);
            tb_diachi.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 284);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 17;
            label4.Text = "Trạng thái";
            // 
            // dtg_show
            // 
            dtg_show.BackgroundColor = SystemColors.Control;
            dtg_show.BorderStyle = BorderStyle.None;
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dtg_show.Location = new Point(454, 22);
            dtg_show.Margin = new Padding(3, 2, 3, 2);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(804, 289);
            dtg_show.TabIndex = 24;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa chỉ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mật khẩu";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 80;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Chức vụ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 152);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 16;
            label3.Text = "SDT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 15;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 14;
            label1.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tb_matkhau);
            panel1.Controls.Add(rd_khd);
            panel1.Controls.Add(rd_hd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbb_cv);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tb_email);
            panel1.Controls.Add(tb_sdt);
            panel1.Controls.Add(tb_ten);
            panel1.Controls.Add(tb_diachi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(75, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 389);
            panel1.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 241);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 43;
            label9.Text = "Mật khẩu";
            // 
            // tb_matkhau
            // 
            tb_matkhau.Location = new Point(174, 236);
            tb_matkhau.Margin = new Padding(3, 2, 3, 2);
            tb_matkhau.Name = "tb_matkhau";
            tb_matkhau.Size = new Size(155, 23);
            tb_matkhau.TabIndex = 42;
            // 
            // rd_khd
            // 
            rd_khd.AutoSize = true;
            rd_khd.Location = new Point(219, 284);
            rd_khd.Margin = new Padding(3, 2, 3, 2);
            rd_khd.Name = "rd_khd";
            rd_khd.Size = new Size(118, 19);
            rd_khd.TabIndex = 37;
            rd_khd.TabStop = true;
            rd_khd.Text = "Không hoạt động";
            rd_khd.UseVisualStyleBackColor = true;
            // 
            // rd_hd
            // 
            rd_hd.AutoSize = true;
            rd_hd.Location = new Point(116, 284);
            rd_hd.Margin = new Padding(3, 2, 3, 2);
            rd_hd.Name = "rd_hd";
            rd_hd.Size = new Size(82, 19);
            rd_hd.TabIndex = 36;
            rd_hd.TabStop = true;
            rd_hd.Text = "Hoạt động";
            rd_hd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 328);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 35;
            label6.Text = "Chức vụ";
            // 
            // cbb_cv
            // 
            cbb_cv.FormattingEnabled = true;
            cbb_cv.Location = new Point(176, 322);
            cbb_cv.Margin = new Padding(3, 2, 3, 2);
            cbb_cv.Name = "cbb_cv";
            cbb_cv.Size = new Size(155, 23);
            cbb_cv.TabIndex = 34;
            // 
            // btn_xoahoadon
            // 
            btn_xoahoadon.Image = (Image)resources.GetObject("btn_xoahoadon.Image");
            btn_xoahoadon.Location = new Point(677, 364);
            btn_xoahoadon.Margin = new Padding(3, 2, 3, 2);
            btn_xoahoadon.Name = "btn_xoahoadon";
            btn_xoahoadon.Size = new Size(120, 47);
            btn_xoahoadon.TabIndex = 32;
            btn_xoahoadon.Text = "Làm mới ";
            btn_xoahoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xoahoadon.UseVisualStyleBackColor = true;
            btn_xoahoadon.Click += btn_xoahoadon_Click;
            // 
            // btn_sua
            // 
            btn_sua.Image = Properties.Resources.icons8_edit_32;
            btn_sua.Location = new Point(836, 364);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(122, 47);
            btn_sua.TabIndex = 31;
            btn_sua.Text = "Sửa nhân viên";
            btn_sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Image = Properties.Resources.icons8_add_new_32;
            btn_hoadon.Location = new Point(494, 364);
            btn_hoadon.Margin = new Padding(3, 2, 3, 2);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(136, 47);
            btn_hoadon.TabIndex = 30;
            btn_hoadon.Text = "Thêm nhân viên";
            btn_hoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hoadon.UseVisualStyleBackColor = true;
            btn_hoadon.Click += button1_Click;
            // 
            // btn_tim
            // 
            btn_tim.Image = (Image)resources.GetObject("btn_tim.Image");
            btn_tim.Location = new Point(979, 364);
            btn_tim.Margin = new Padding(3, 2, 3, 2);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(100, 47);
            btn_tim.TabIndex = 33;
            btn_tim.Text = "Thoát";
            btn_tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1304, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // FrmNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 434);
            Controls.Add(btn_xoahoadon);
            Controls.Add(btn_sua);
            Controls.Add(btn_hoadon);
            Controls.Add(btn_tim);
            Controls.Add(dtg_show);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmNV";
            Text = "FrmNV";
            Load += FrmNV_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox tb_email;
        private TextBox tb_sdt;
        private TextBox tb_ten;
        private TextBox tb_diachi;
        private Label label4;
        private DataGridView dtg_show;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btn_xoahoadon;
        private Button btn_sua;
        private Button btn_hoadon;
        private Button btn_tim;
        private Label label6;
        private ComboBox cbb_cv;
        private RadioButton rd_khd;
        private RadioButton rd_hd;
        private Label label9;
        private TextBox tb_matkhau;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private MenuStrip menuStrip1;
    }
}