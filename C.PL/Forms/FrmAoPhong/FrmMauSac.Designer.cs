namespace C.PL.Forms.FrmSanpham2
{
    partial class FrmMauSac
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
            groupBox3 = new GroupBox();
            dgv_Mau = new DataGridView();
            groupBox2 = new GroupBox();
            btn_thoat = new Button();
            btn_lamMoi = new Button();
            btn_Xoa = new Button();
            btn_them = new Button();
            groupBox1 = new GroupBox();
            rb_KHD = new RadioButton();
            rb_HoatDong = new RadioButton();
            label3 = new Label();
            txt_TenMau = new TextBox();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Mau).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_Mau);
            groupBox3.Location = new Point(100, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(786, 330);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách màu sắc";
            // 
            // dgv_Mau
            // 
            dgv_Mau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Mau.Location = new Point(-3, 37);
            dgv_Mau.Name = "dgv_Mau";
            dgv_Mau.RowHeadersWidth = 51;
            dgv_Mau.RowTemplate.Height = 29;
            dgv_Mau.Size = new Size(789, 290);
            dgv_Mau.TabIndex = 0;
            dgv_Mau.CellClick += dgv_Mau_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_thoat);
            groupBox2.Controls.Add(btn_lamMoi);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new Point(551, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 242);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_thoat
            // 
            btn_thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thoat.Location = new Point(176, 104);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(138, 50);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_lamMoi
            // 
            btn_lamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lamMoi.Location = new Point(21, 104);
            btn_lamMoi.Name = "btn_lamMoi";
            btn_lamMoi.Size = new Size(138, 50);
            btn_lamMoi.TabIndex = 2;
            btn_lamMoi.Text = "Làm mới";
            btn_lamMoi.UseVisualStyleBackColor = true;
            btn_lamMoi.Click += btn_lamMoi_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(176, 35);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(138, 50);
            btn_Xoa.TabIndex = 1;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_them
            // 
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(21, 36);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(138, 50);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_KHD);
            groupBox1.Controls.Add(rb_HoatDong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenMau);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(97, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 242);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin màu sắc";
            // 
            // rb_KHD
            // 
            rb_KHD.AutoSize = true;
            rb_KHD.Location = new Point(306, 159);
            rb_KHD.Name = "rb_KHD";
            rb_KHD.Size = new Size(91, 24);
            rb_KHD.TabIndex = 6;
            rb_KHD.TabStop = true;
            rb_KHD.Text = "Hết hàng";
            rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            rb_HoatDong.AutoSize = true;
            rb_HoatDong.Location = new Point(186, 159);
            rb_HoatDong.Name = "rb_HoatDong";
            rb_HoatDong.Size = new Size(93, 24);
            rb_HoatDong.TabIndex = 5;
            rb_HoatDong.TabStop = true;
            rb_HoatDong.Text = "Còn hàng";
            rb_HoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 163);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // txt_TenMau
            // 
            txt_TenMau.Location = new Point(186, 101);
            txt_TenMau.Name = "txt_TenMau";
            txt_TenMau.Size = new Size(211, 27);
            txt_TenMau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 102);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên màu sắc";
            // 
            // FrmMauSac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 706);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmMauSac";
            Text = "FrmMauSac";
            Load += FrmMauSac_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Mau).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgv_Mau;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private Button btn_Xoa;
        private Button btn_them;
        private GroupBox groupBox1;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox txt_TenMau;
        private Label label2;
    }
}