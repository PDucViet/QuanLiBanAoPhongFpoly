namespace C.PL.Forms
{
    partial class FrmHang
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
            dtgv_NSX = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btn_thoat = new Button();
            btn_lamMoi = new Button();
            btb_CapNhat = new Button();
            btn_them = new Button();
            groupBox1 = new GroupBox();
            rb_KHD = new RadioButton();
            rb_HoatDong = new RadioButton();
            label3 = new Label();
            tbt_TenNSX = new TextBox();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_NSX).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_NSX);
            groupBox3.Location = new Point(87, 296);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(786, 330);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhà sản xuất";
            // 
            // dtgv_NSX
            // 
            dtgv_NSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NSX.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dtgv_NSX.Location = new Point(-3, 37);
            dtgv_NSX.Name = "dtgv_NSX";
            dtgv_NSX.RowHeadersWidth = 51;
            dtgv_NSX.RowTemplate.Height = 29;
            dtgv_NSX.Size = new Size(789, 290);
            dtgv_NSX.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NSX";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên NSX";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_thoat);
            groupBox2.Controls.Add(btn_lamMoi);
            groupBox2.Controls.Add(btb_CapNhat);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new Point(538, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 242);
            groupBox2.TabIndex = 4;
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
            // 
            // btb_CapNhat
            // 
            btb_CapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btb_CapNhat.Location = new Point(176, 35);
            btb_CapNhat.Name = "btb_CapNhat";
            btb_CapNhat.Size = new Size(138, 50);
            btb_CapNhat.TabIndex = 1;
            btb_CapNhat.Text = "Cập nhật";
            btb_CapNhat.UseVisualStyleBackColor = true;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_KHD);
            groupBox1.Controls.Add(rb_HoatDong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbt_TenNSX);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(84, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 242);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà sản xuất";
            // 
            // rb_KHD
            // 
            rb_KHD.AutoSize = true;
            rb_KHD.Location = new Point(265, 161);
            rb_KHD.Name = "rb_KHD";
            rb_KHD.Size = new Size(146, 24);
            rb_KHD.TabIndex = 6;
            rb_KHD.TabStop = true;
            rb_KHD.Text = "Không hoạt động";
            rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            rb_HoatDong.AutoSize = true;
            rb_HoatDong.Location = new Point(157, 161);
            rb_HoatDong.Name = "rb_HoatDong";
            rb_HoatDong.Size = new Size(102, 24);
            rb_HoatDong.TabIndex = 5;
            rb_HoatDong.TabStop = true;
            rb_HoatDong.Text = "Hoạt động";
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
            // tbt_TenNSX
            // 
            tbt_TenNSX.Location = new Point(186, 101);
            tbt_TenNSX.Name = "tbt_TenNSX";
            tbt_TenNSX.Size = new Size(211, 27);
            tbt_TenNSX.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 102);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhà sản xuất";
            // 
            // FrmHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 670);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmHang";
            Text = "FrmHang";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_NSX).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgv_NSX;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private GroupBox groupBox1;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tbt_TenNSX;
        private Label label2;
    }
}