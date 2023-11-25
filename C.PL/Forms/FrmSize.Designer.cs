namespace C.PL
{
    partial class FrmSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSize));
            groupBox1 = new GroupBox();
            rb_KHD = new RadioButton();
            rb_HoatDong = new RadioButton();
            label3 = new Label();
            tbt_TenSize = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dtgv_Size = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btn_thoat = new Button();
            btn_lamMoi = new Button();
            btb_CapNhat = new Button();
            btn_them = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Size).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_KHD);
            this.groupBox1.Controls.Add(this.rb_HoatDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbt_TenSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin size";
            // 
            // rb_KHD
            // 
            this.rb_KHD.AutoSize = true;
            this.rb_KHD.Location = new System.Drawing.Point(306, 159);
            this.rb_KHD.Name = "rb_KHD";
            this.rb_KHD.Size = new System.Drawing.Size(91, 24);
            this.rb_KHD.TabIndex = 6;
            this.rb_KHD.TabStop = true;
            this.rb_KHD.Text = "Hết hàng";
            this.rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            this.rb_HoatDong.AutoSize = true;
            this.rb_HoatDong.Location = new System.Drawing.Point(186, 159);
            this.rb_HoatDong.Name = "rb_HoatDong";
            this.rb_HoatDong.Size = new System.Drawing.Size(93, 24);
            this.rb_HoatDong.TabIndex = 5;
            this.rb_HoatDong.TabStop = true;
            this.rb_HoatDong.Text = "Còn hàng";
            this.rb_HoatDong.UseVisualStyleBackColor = true;
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
            // tbt_TenSize
            // 
            this.tbt_TenSize.Location = new System.Drawing.Point(186, 101);
            this.tbt_TenSize.Name = "tbt_TenSize";
            this.tbt_TenSize.Size = new System.Drawing.Size(211, 27);
            this.tbt_TenSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_Size);
            this.groupBox3.Location = new System.Drawing.Point(59, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 330);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách size";
            // 
            // dtgv_Size
            // 
            this.dtgv_Size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Size.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_Size.Location = new System.Drawing.Point(-3, 37);
            this.dtgv_Size.Name = "dtgv_Size";
            this.dtgv_Size.RowHeadersWidth = 51;
            this.dtgv_Size.RowTemplate.Height = 29;
            this.dtgv_Size.Size = new System.Drawing.Size(789, 290);
            this.dtgv_Size.TabIndex = 0;
            // 
            // Column2
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã Size";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Size";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tình trạng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.btb_CapNhat);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(510, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 242);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(176, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 50);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.Image")));
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(21, 104);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(138, 50);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btb_CapNhat
            // 
            this.btb_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btb_CapNhat.Location = new System.Drawing.Point(176, 35);
            this.btb_CapNhat.Name = "btb_CapNhat";
            this.btb_CapNhat.Size = new System.Drawing.Size(138, 50);
            this.btb_CapNhat.TabIndex = 1;
            this.btb_CapNhat.Text = "Cập nhật";
            this.btb_CapNhat.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(21, 36);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(138, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // FrmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSize";
            this.Text = "FrmSize";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Size)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbt_TenSize;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dtgv_Size;
        private GroupBox groupBox2;
        private Button btn_thoat;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}