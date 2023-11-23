namespace C.PL.Forms
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            btn_xoahoadon = new Button();
            btn_sua = new Button();
            btn_hoadon = new Button();
            btn_tim = new Button();
            dtg_show = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label9 = new Label();
            tb_matkhau = new TextBox();
            rd_khd = new RadioButton();
            rd_hd = new RadioButton();
            label6 = new Label();
            cbb_cv = new ComboBox();
            label5 = new Label();
            tb_email = new TextBox();
            tb_sdt = new TextBox();
            tb_ten = new TextBox();
            tb_diachi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_xoahoadon
            // 
            btn_xoahoadon.Image = (Image)resources.GetObject("btn_xoahoadon.Image");
            btn_xoahoadon.Location = new Point(759, 443);
            btn_xoahoadon.Name = "btn_xoahoadon";
            btn_xoahoadon.Size = new Size(137, 63);
            btn_xoahoadon.TabIndex = 38;
            btn_xoahoadon.Text = "Làm mới ";
            btn_xoahoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xoahoadon.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(953, 443);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(139, 63);
            btn_sua.TabIndex = 37;
            btn_sua.Text = "Sửa nhân viên";
            btn_sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Location = new Point(537, 443);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(156, 63);
            btn_hoadon.TabIndex = 36;
            btn_hoadon.Text = "Thêm nhân viên";
            btn_hoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hoadon.UseVisualStyleBackColor = true;
            // 
            // btn_tim
            // 
            btn_tim.Image = (Image)resources.GetObject("btn_tim.Image");
            btn_tim.Location = new Point(1154, 443);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(114, 63);
            btn_tim.TabIndex = 39;
            btn_tim.Text = "Thoát";
            btn_tim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tim.UseVisualStyleBackColor = true;
            // 
            // dtg_show
            // 
            dtg_show.BackgroundColor = SystemColors.Control;
            dtg_show.BorderStyle = BorderStyle.None;
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dtg_show.Location = new Point(427, 12);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(919, 385);
            dtg_show.TabIndex = 34;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tb_matkhau);
            groupBox1.Controls.Add(rd_khd);
            groupBox1.Controls.Add(rd_hd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbb_cv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_ten);
            groupBox1.Controls.Add(tb_diachi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 494);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin nhân viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 303);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 58;
            label9.Text = "Mật khẩu";
            // 
            // tb_matkhau
            // 
            tb_matkhau.Location = new Point(169, 296);
            tb_matkhau.Name = "tb_matkhau";
            tb_matkhau.Size = new Size(177, 27);
            tb_matkhau.TabIndex = 57;
            // 
            // rd_khd
            // 
            rd_khd.AutoSize = true;
            rd_khd.Location = new Point(220, 361);
            rd_khd.Name = "rd_khd";
            rd_khd.Size = new Size(146, 24);
            rd_khd.TabIndex = 56;
            rd_khd.TabStop = true;
            rd_khd.Text = "Không hoạt động";
            rd_khd.UseVisualStyleBackColor = true;
            // 
            // rd_hd
            // 
            rd_hd.AutoSize = true;
            rd_hd.Location = new Point(102, 361);
            rd_hd.Name = "rd_hd";
            rd_hd.Size = new Size(102, 24);
            rd_hd.TabIndex = 55;
            rd_hd.TabStop = true;
            rd_hd.Text = "Hoạt động";
            rd_hd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 419);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 54;
            label6.Text = "Chức vụ";
            // 
            // cbb_cv
            // 
            cbb_cv.FormattingEnabled = true;
            cbb_cv.Location = new Point(171, 411);
            cbb_cv.Name = "cbb_cv";
            cbb_cv.Size = new Size(177, 28);
            cbb_cv.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 243);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 52;
            label5.Text = "Email";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(169, 236);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(177, 27);
            tb_email.TabIndex = 51;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(169, 177);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(177, 27);
            tb_sdt.TabIndex = 50;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(169, 56);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(177, 27);
            tb_ten.TabIndex = 49;
            // 
            // tb_diachi
            // 
            tb_diachi.Location = new Point(169, 119);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(177, 27);
            tb_diachi.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 361);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 47;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 184);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 46;
            label3.Text = "SDT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 45;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 44;
            label1.Text = "Tên nhân viên";
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 551);
            Controls.Add(groupBox1);
            Controls.Add(btn_xoahoadon);
            Controls.Add(btn_sua);
            Controls.Add(btn_hoadon);
            Controls.Add(btn_tim);
            Controls.Add(dtg_show);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_xoahoadon;
        private Button btn_sua;
        private Button btn_hoadon;
        private Button btn_tim;
        private DataGridView dtg_show;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox tb_matkhau;
        private RadioButton rd_khd;
        private RadioButton rd_hd;
        private Label label6;
        private ComboBox cbb_cv;
        private Label label5;
        private TextBox tb_email;
        private TextBox tb_sdt;
        private TextBox tb_ten;
        private TextBox tb_diachi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}